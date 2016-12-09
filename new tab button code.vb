
'sample code for new tab'
Dim myTabPage As New TabPage()
myTabPage.Text = "TabPage" & (TabControl1.TabPages.Count + 1)
TabControl1.TabPages.Add(myTabPage)
