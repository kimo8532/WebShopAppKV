using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopLibrary
{
    public class InvoiceRepository
    {
        public void CreateInvoice(Invoice invoice)
        {
            string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
            using (DbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (DbCommand command = connection.CreateCommand())
                {

                    command.CommandText = "INSERT INTO Nemet_Receipt (paymentmethod, address, name, surname, phonenumber, city, postalcode, creditCardNumber, expirationDate, cancelled) VALUES (@paymentmethod, @address, @name, @surname, @phonenumber, @city, @postalcode, @creditCardNumber, @expirationDate, 0)";
                    command.Parameters.Add(new SqlParameter("@paymentmethod", SqlDbType.NVarChar) { Value = invoice.paymentmethod });
                    command.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar) { Value = invoice.address });
                    command.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar) { Value = invoice.name });
                    command.Parameters.Add(new SqlParameter("@surname", SqlDbType.NVarChar) { Value = invoice.surname });
                    command.Parameters.Add(new SqlParameter("@phonenumber", SqlDbType.NVarChar) { Value = invoice.phonenumber });
                    command.Parameters.Add(new SqlParameter("@city", SqlDbType.NVarChar) { Value = invoice.city });
                    command.Parameters.Add(new SqlParameter("@postalcode", SqlDbType.NVarChar) { Value = invoice.postalcode });
                    command.Parameters.Add(new SqlParameter("@creditCardNumber", SqlDbType.NVarChar) { Value = invoice.creditCardNumber });
                    command.Parameters.Add(new SqlParameter("@expirationDate", SqlDbType.NVarChar) { Value = invoice.expirationDate });
                    command.ExecuteNonQuery();
                }
                // get the newly created invoice id
                int invoiceId = 0;
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT MAX(id) FROM Nemet_Receipt";
                    invoiceId = (int)command.ExecuteScalar();

                }
                using (DbCommand command = connection.CreateCommand())
                {
                    int i = 0;
                    foreach(Product product in invoice.shoppingCart.Products) 
                    {
                        
                        command.CommandText = "INSERT INTO Nemet_Receipt (idreceipt, idproduct, quantity) VALUES (@idreceipt, @idproduct, @quantity)";
                        command.Parameters.Add(new SqlParameter("@idreceipt", SqlDbType.NVarChar) { Value = invoiceId });
                        command.Parameters.Add(new SqlParameter("@idproduct", SqlDbType.NVarChar) { Value = product.id });
                        command.Parameters.Add(new SqlParameter("@quantity", SqlDbType.NVarChar) { Value = invoice.shoppingCart.ProductQuantity[i]});
                        command.ExecuteNonQuery();
                        i++;
                    }
                    
                }
            }
        }
    }
}
