  string FromEmailId = "wchild30@gmail.com";
                    string FromEmailPassword = "alap152207alap";
                    string userid = dr["UserObjId"].ToString();
                    string bodymsg = "Greetings user!<br> This is an automated mail to activate your account registered on IPOC.<br>Please visit the below link to activate your account<br> http://localhost:56844/useractivation.aspx?activationcode=" + userid;
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress(FromEmailId, "IPOC");
                    msg.To.Add(ToEmailId);
                    msg.Subject = "IPOC Account Activation";
                    msg.Body = bodymsg;
                    SmtpClient client = new SmtpClient();
                    client.UseDefaultCredentials = true;
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Credentials = new NetworkCredential(FromEmailId, FromEmailPassword);
                    client.Timeout = 20000;
                    con.Close();

                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("update userobj set CrtDt='" +DateTime.Now + "'", con);
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    try
                    {
                        client.Send(msg);
                        Response.Write("Email Activation Link has been sent to your email address,please activate within a day");
                    }
                    catch (Exception ex)
                    {
                        Response.Write("Sorry,Our Email Verification is not working right now,please visit again,Error message:" + ex.ToString());
                    }
