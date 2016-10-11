using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using System.Xml.Serialization;
using System.Xml;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WorkflowActions;
using Microsoft.Office.Workflow.Utility;

namespace DemoSharePointWorkflow
{
	public sealed partial class Workflow1: SequentialWorkflowActivity
	{
		public Workflow1()
		{
			InitializeComponent();
		}

        public Guid workflowId = default(System.Guid);
        public Microsoft.SharePoint.Workflow.SPWorkflowActivationProperties workflowProperties = new Microsoft.SharePoint.Workflow.SPWorkflowActivationProperties();
        private string instructions = default(String);
        private DateTime submitDate = default(DateTime);

        private void onInvoked(object sender, ExternalDataEventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(SubmitExpenses));
            XmlTextReader xtr = new XmlTextReader(new System.IO.StringReader(workflowProperties.InitiationData));
            SubmitExpenses expenses = (SubmitExpenses)xs.Deserialize(xtr);

            instructions = expenses.SubmitComments;
            if (expenses.SubmitDateSpecified)
                submitDate = (DateTime)expenses.SubmitDate;

            workflowProperties.Item.Properties["Status"] = "Processing";
            workflowId = workflowProperties.WorkflowId;
        }

        private void ifTotalGreater(object sender, ConditionalEventArgs e)
        {
            if ((int)workflowProperties.Item.Properties["Total"] > 1000)
                e.Result = true;
        }

        private void AutoApproveCondition(object sender, ConditionalEventArgs e)
        {
            if ((int)workflowProperties.Item.Properties["Total"] < 100)
                e.Result = true; 
        }

        private void FinishWorkflow(object sender, EventArgs e)
        {
            string tmpPurpose = (string)workflowProperties.Item.Properties["Purpose"];
            workflowProperties.Item.Properties["Purpose"] = tmpPurpose + ", Approved Automatically.";
            workflowProperties.Item.Properties["Status"] = "Approved";
        }

        public Guid TaskForManagerApproval_TaskId1 = default(System.Guid);
        public Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties TaskForManagerApproval_TaskProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void CreateMgrTask(object sender, EventArgs e)
        {
            TaskForManagerApproval_TaskId1 = Guid.NewGuid();
            TaskForManagerApproval_TaskProperties1.Title = "Approve Expense Report";
            TaskForManagerApproval_TaskProperties1.AssignedTo = (string)workflowProperties.Item.Properties["Manager Name"];
            TaskForManagerApproval_TaskProperties1.Description = instructions;
            TaskForManagerApproval_TaskProperties1.ExtendedProperties["comments"] = instructions;
        }

        private bool mgrApproved = false;

        private void MgrApproved(object sender, ConditionalEventArgs e)
        {
            TimeSpan nbrDays = DateTime.Now.Subtract(submitDate);
            e.Result = !((mgrApproved) || (nbrDays.Days > 10));
        }

        public Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties ManagerApprovedTask_AfterProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties ManagerApprovedTask_BeforeProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void ManagerApproved(object sender, ExternalDataEventArgs e)
        {
            mgrApproved = bool.Parse(ManagerApprovedTask_AfterProperties1.ExtendedProperties["isFinished"].ToString());
        }

	}

}
