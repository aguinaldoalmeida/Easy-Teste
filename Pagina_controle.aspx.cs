using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    string connectionString = @"Data Source=AGUINALDO\SQL_EXPRESS;Initial Catalog=easy;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopularGridView();
        }
    }

    void PopularGridView()
    {
        DataTable dtbl = new DataTable();
        using (SqlConnection sqlCon = new SqlConnection(connectionString))
        {
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM cadastroeasy", sqlCon);
            sqlDa.Fill(dtbl);
        }

        if (dtbl.Rows.Count > 0)
        {
            // aqui menciona o campo do gridview 
            gvcadastroeasy.DataSource = dtbl;
            gvcadastroeasy.DataBind();
        }

        else
        {
            dtbl.Rows.Add(dtbl.NewRow());
            gvcadastroeasy.DataSource = dtbl;
            gvcadastroeasy.DataBind();
            gvcadastroeasy.Rows[0].Cells.Clear();
            gvcadastroeasy.Rows[0].Cells.Add(new TableCell());
            gvcadastroeasy.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
            gvcadastroeasy.Rows[0].Cells[0].Text = "Dados não encontrados !";
            gvcadastroeasy.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;


        }

        

    }

    protected void gvPhoneBook_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName.Equals("AddNew"))
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "INSERT INTO cadastroeasy (nome, telefone, cidade, estado) values (@nome, @telefone, @cidade, @estado)";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@nome", (gvcadastroeasy.FooterRow.FindControl("txtnomeFooter") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@telefone", (gvcadastroeasy.FooterRow.FindControl("txttelefoneFooter") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@cidade", (gvcadastroeasy.FooterRow.FindControl("txtcidadeFooter") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@estado", (gvcadastroeasy.FooterRow.FindControl("txtestadoFooter") as TextBox).Text.Trim());

                    sqlCmd.ExecuteNonQuery();
                    PopularGridView();
                    lblSucessMessage.Text = "Dados gravados com sucesso !";
                    lblErrorMessage.Text = "";

                }
            }
        }
        catch (Exception ex)
        {
            lblSucessMessage.Text = "";
            lblErrorMessage.Text = ex.Message;

        }
    }

    protected void gvPhoneBook_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvcadastroeasy.EditIndex = e.NewEditIndex;
        PopularGridView();
    }

    protected void gvPhoneBook_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvcadastroeasy.EditIndex = -1;
        PopularGridView();
    }

    protected void gvPhoneBook_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
              using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "UPDATE cadastroeasy SET nome=@nome, telefone=@telefone, cidade=@cidade, estado=@estado WHERE id = @id";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@nome", (gvcadastroeasy.Rows[e.RowIndex].FindControl("txtnome") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@telefone", (gvcadastroeasy.Rows[e.RowIndex].FindControl("txttelefone") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@cidade", (gvcadastroeasy.Rows[e.RowIndex].FindControl("txtcidade") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@estado", (gvcadastroeasy.Rows[e.RowIndex].FindControl("txtestado") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(gvcadastroeasy.DataKeys[e.RowIndex].Value.ToString()));

                    sqlCmd.ExecuteNonQuery();
                gvcadastroeasy.EditIndex = -1;
                    PopularGridView();
                    lblSucessMessage.Text = "Selecione os dados !";
                    lblErrorMessage.Text = "";

                }
            
        }
        catch (Exception ex)
        {
            lblSucessMessage.Text = "";
            lblErrorMessage.Text = ex.Message;

        }
    }

    protected void gvPhoneBook_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "DELETE FROM cadastroeasy WHERE id = @id";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(gvcadastroeasy.DataKeys[e.RowIndex].Value.ToString()));

                sqlCmd.ExecuteNonQuery();
               
                PopularGridView();
                lblSucessMessage.Text = "Dados Deletados com Sucesso !";
                lblErrorMessage.Text = "";

            }

        }
        catch (Exception ex)
        {
            lblSucessMessage.Text = "";
            lblErrorMessage.Text = ex.Message;

        }
    }
}
