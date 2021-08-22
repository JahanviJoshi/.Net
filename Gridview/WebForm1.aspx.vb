Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        {
           var
        var d = New DataClassesDataContext();
           var c = New product();
           c.pname = TextBox1.Text;
           c.pprice = TextBox2.Text;
           d.products.InsertOnSubmit(c);
           d.SubmitChanges(); 
           Label3.Text = "Successfully Added dATA";
         }
    End Sub
End Class