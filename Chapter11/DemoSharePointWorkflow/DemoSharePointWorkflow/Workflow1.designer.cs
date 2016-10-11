using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace DemoSharePointWorkflow
{
	public sealed partial class Workflow1
	{
		#region Designer generated code
		
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.CanModifyActivities = true;
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken2 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.CodeCondition codecondition2 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.CodeCondition codecondition3 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            this.ExitWorkflow = new System.Workflow.ComponentModel.TerminateActivity();
            this.ApproveItem = new System.Workflow.Activities.CodeActivity();
            this.ElseContinue = new System.Workflow.Activities.IfElseBranchActivity();
            this.AutoApprove = new System.Workflow.Activities.IfElseBranchActivity();
            this.IsTotalUnderOneHundred = new System.Workflow.Activities.IfElseActivity();
            this.NotifyFinanceByEmail = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.ManagerApprovedTask = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.ElseDoNothing = new System.Workflow.Activities.IfElseBranchActivity();
            this.NotifyFinance = new System.Workflow.Activities.IfElseBranchActivity();
            this.MgrApprovedTask = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.WhileWaitingApproval = new System.Workflow.Activities.WhileActivity();
            this.TaskForManagerApproval = new Microsoft.SharePoint.WorkflowActions.CreateTask();
            this.IsTotalOverOneThousand = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            // 
            // ExitWorkflow
            // 
            this.ExitWorkflow.Name = "ExitWorkflow";
            // 
            // ApproveItem
            // 
            this.ApproveItem.Name = "ApproveItem";
            this.ApproveItem.ExecuteCode += new System.EventHandler(this.FinishWorkflow);
            // 
            // ElseContinue
            // 
            this.ElseContinue.Name = "ElseContinue";
            // 
            // AutoApprove
            // 
            this.AutoApprove.Activities.Add(this.ApproveItem);
            this.AutoApprove.Activities.Add(this.ExitWorkflow);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.AutoApproveCondition);
            this.AutoApprove.Condition = codecondition1;
            this.AutoApprove.Name = "AutoApprove";
            // 
            // IsTotalUnderOneHundred
            // 
            this.IsTotalUnderOneHundred.Activities.Add(this.AutoApprove);
            this.IsTotalUnderOneHundred.Activities.Add(this.ElseContinue);
            this.IsTotalUnderOneHundred.Name = "IsTotalUnderOneHundred";
            // 
            // NotifyFinanceByEmail
            // 
            this.NotifyFinanceByEmail.BCC = null;
            this.NotifyFinanceByEmail.Body = null;
            this.NotifyFinanceByEmail.CC = null;
            correlationtoken1.Name = "workflowToken";
            correlationtoken1.OwnerActivityName = "Workflow1";
            this.NotifyFinanceByEmail.CorrelationToken = correlationtoken1;
            this.NotifyFinanceByEmail.From = "sender@example.org";
            this.NotifyFinanceByEmail.Headers = null;
            this.NotifyFinanceByEmail.IncludeStatus = false;
            this.NotifyFinanceByEmail.Name = "NotifyFinanceByEmail";
            this.NotifyFinanceByEmail.Subject = "Expense Report Over $1,000";
            this.NotifyFinanceByEmail.To = "recipient@example.org";
            // 
            // ManagerApprovedTask
            // 
            activitybind1.Name = "Workflow1";
            activitybind1.Path = "ManagerApprovedTask_AfterProperties1";
            activitybind2.Name = "Workflow1";
            activitybind2.Path = "ManagerApprovedTask_BeforeProperties1";
            correlationtoken2.Name = "mgrTaskToken";
            correlationtoken2.OwnerActivityName = "Workflow1";
            this.ManagerApprovedTask.CorrelationToken = correlationtoken2;
            this.ManagerApprovedTask.Executor = null;
            this.ManagerApprovedTask.Name = "ManagerApprovedTask";
            activitybind3.Name = "Workflow1";
            activitybind3.Path = "TaskForManagerApproval_TaskId1";
            this.ManagerApprovedTask.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.ManagerApproved);
            this.ManagerApprovedTask.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.ManagerApprovedTask.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.ManagerApprovedTask.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            // 
            // ElseDoNothing
            // 
            this.ElseDoNothing.Activities.Add(this.IsTotalUnderOneHundred);
            this.ElseDoNothing.Name = "ElseDoNothing";
            // 
            // NotifyFinance
            // 
            this.NotifyFinance.Activities.Add(this.NotifyFinanceByEmail);
            codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ifTotalGreater);
            this.NotifyFinance.Condition = codecondition2;
            this.NotifyFinance.Name = "NotifyFinance";
            // 
            // MgrApprovedTask
            // 
            this.MgrApprovedTask.CorrelationToken = correlationtoken2;
            this.MgrApprovedTask.Name = "MgrApprovedTask";
            activitybind4.Name = "Workflow1";
            activitybind4.Path = "TaskForManagerApproval_TaskId1";
            this.MgrApprovedTask.TaskOutcome = null;
            this.MgrApprovedTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            // 
            // WhileWaitingApproval
            // 
            this.WhileWaitingApproval.Activities.Add(this.ManagerApprovedTask);
            codecondition3.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.MgrApproved);
            this.WhileWaitingApproval.Condition = codecondition3;
            this.WhileWaitingApproval.Name = "WhileWaitingApproval";
            // 
            // TaskForManagerApproval
            // 
            this.TaskForManagerApproval.CorrelationToken = correlationtoken2;
            this.TaskForManagerApproval.ListItemId = -1;
            this.TaskForManagerApproval.Name = "TaskForManagerApproval";
            this.TaskForManagerApproval.SpecialPermissions = null;
            activitybind5.Name = "Workflow1";
            activitybind5.Path = "TaskForManagerApproval_TaskId1";
            activitybind6.Name = "Workflow1";
            activitybind6.Path = "TaskForManagerApproval_TaskProperties1";
            this.TaskForManagerApproval.MethodInvoking += new System.EventHandler(this.CreateMgrTask);
            this.TaskForManagerApproval.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            this.TaskForManagerApproval.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            // 
            // IsTotalOverOneThousand
            // 
            this.IsTotalOverOneThousand.Activities.Add(this.NotifyFinance);
            this.IsTotalOverOneThousand.Activities.Add(this.ElseDoNothing);
            this.IsTotalOverOneThousand.Name = "IsTotalOverOneThousand";
            activitybind8.Name = "Workflow1";
            activitybind8.Path = "workflowId";
            // 
            // onWorkflowActivated1
            // 
            this.onWorkflowActivated1.CorrelationToken = correlationtoken1;
            this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated1.Name = "onWorkflowActivated1";
            activitybind7.Name = "Workflow1";
            activitybind7.Path = "workflowProperties";
            this.onWorkflowActivated1.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onInvoked);
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            // 
            // Workflow1
            // 
            this.Activities.Add(this.onWorkflowActivated1);
            this.Activities.Add(this.IsTotalOverOneThousand);
            this.Activities.Add(this.TaskForManagerApproval);
            this.Activities.Add(this.WhileWaitingApproval);
            this.Activities.Add(this.MgrApprovedTask);
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

		}

		#endregion

        private Microsoft.SharePoint.WorkflowActions.CompleteTask MgrApprovedTask;
        private IfElseBranchActivity ElseDoNothing;
        private IfElseBranchActivity NotifyFinance;
        private IfElseActivity IsTotalOverOneThousand;
        private IfElseBranchActivity ElseContinue;
        private IfElseBranchActivity AutoApprove;
        private IfElseActivity IsTotalUnderOneHundred;
        private Microsoft.SharePoint.WorkflowActions.SendEmail NotifyFinanceByEmail;
        private TerminateActivity ExitWorkflow;
        private CodeActivity ApproveItem;
        private WhileActivity WhileWaitingApproval;
        private Microsoft.SharePoint.WorkflowActions.CreateTask TaskForManagerApproval;
        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged ManagerApprovedTask;
        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated1;



























    }
}
