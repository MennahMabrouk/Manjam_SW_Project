<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Opportunity Manager.aspx.cs"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Opportunity Manager</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Opportunity Manager</h1>
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="opportunity_id" DataSourceID="sqlDataSource">
                <Columns>
                    <asp:BoundField DataField="opportunity_id" HeaderText="Opportunity ID" 
                        ReadOnly="True" SortExpression="opportunity_id" />
                    <asp:BoundField DataField="title" HeaderText="Title" SortExpression="title" />
                    <asp:TemplateField HeaderText="Image">
                        <ItemTemplate>
                          <!--  <asp:Image ID="image" runat="server" ImageUrl=' //"data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image")) %>' Width="100" />-->
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="details" HeaderText="Details" SortExpression="details" />
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="sqlDataSource" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT * FROM [Opportunity]" 
                DeleteCommand="DELETE FROM [Opportunity] WHERE [opportunity_id] = @opportunity_id"
                InsertCommand="INSERT INTO [Opportunity] ([title], [image], [details]) VALUES (@title, @image, @details)"
                UpdateCommand="UPDATE [Opportunity] SET [title] = @title, [image] = @image, [details] = @details WHERE [opportunity_id] = @opportunity_id">
                <DeleteParameters>
                    <asp:Parameter Name="opportunity_id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="title" Type="String" />
                    <asp:Parameter Name="image" Type="Binary" />
                    <asp:Parameter Name="details" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="title" Type="String" />
                    <asp:Parameter Name="image" Type="Binary" />
                    <asp:Parameter Name="details" Type="String" />
                    <asp:Parameter Name="opportunity_id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>