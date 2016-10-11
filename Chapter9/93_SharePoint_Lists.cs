LitwareLists.Lists listService=new LitwareLists.Lists();
listService.Credentials = System.Net.CredentialCache.DefaultCredentials;
XmlNode node = listService.GetListCollection();

XPathNavigator lists=this.DataSources["ListsXML"].CreateNavigator();
lists.MoveToChild("Lists", "");
lists.MoveToChild("List", "");
lists.DeleteSelf();
lists.MoveToChild("List", "");
lists.DeleteSelf();

foreach (XmlNode listNode in node)
{
    if (listNode.Attributes["ServerTemplate"].Value == "109")
    {
        string title = listNode.Attributes["Title"].Value;

        XmlWriter xw= lists.AppendChild();
        xw.WriteStartElement("List");
        xw.WriteAttributeString("Title", title);
        xw.WriteEndElement();
        xw.Close();
    }
}
