try
{
    string newValue = e.NewValue;
    decimal total = decimal.Parse(newValue);

    XPathNodeIterator optSect= MainDataSource.CreateNavigator().Select("/my:expenseReport/my:OptionalJustification", NamespaceManager);
    
    if (total>=500 && optSect.Count==0)
    {
        this.CurrentView.ExecuteAction(ActionType.XOptionalInsert, "group1_518"); 
    }

    if(total<500 && optSect.Count>0)
    {
        XPathNavigator node = MainDataSource.CreateNavigator().SelectSingleNode("/my:expenseReport/my:OptionalJustification",NamespaceManager);
        CurrentView.SelectNodes(node, node, "CTRL362");
        CurrentView.ExecuteAction(ActionType.XOptionalRemove, "group1_518");
    }
}
catch (NullReferenceException)
{
    //eat the "no currentview" exception
}
