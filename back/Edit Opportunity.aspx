<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit Opportunity.aspx.cs" Inherits="manjam_backend.Edit_Opportunity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Opportunity</title>
</head>
<body>
    <form id="form1" runat="server" method="post" enctype="multipart/form-data">
        <div>
            <h1>Edit Opportunity</h1>
            <p>
                <label for="title">Title:</label><br />
                <input type="text" id="title" name="title"  />
            </p>
            <p>
                <label for="image">Image:</label><br />
                <input type="file" id="image" name="image" accept="image/*" />
            </p>
            <p>
                <label for="details">Details:</label><br />
                <textarea id="details" name="details"></textarea>
            </p>
            <p>
                <input type="submit" value="Save" />
            </p>
        </div>
    </form>
</body>
</html>