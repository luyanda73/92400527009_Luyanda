using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineHardware
{
    public partial class OnlineHardware : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("D:\\92400527009_LuyandaKunene\\OnlineHardware\\App_Data\\Database1.mdf");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
         
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Hardware_Item(item_name, category, price, quantity) " +
                "VALUES(@name, @category, @price, @quantity)", con);

            cmd.ExecuteNonQuery();

            con.Close();

            Label1.Text = "Item inserted successfully!";

        }

       
        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Hardware_Item WHERE item_id=@id", con);

            cmd.ExecuteNonQuery();

            con.Close();

            Label1.Text = "Item deleted successfully!";

        }

    }
}
