﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Tool
{
    public class Class1
    {

        public  void mail(string ma)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("thaong22.03@gmail.com");

            mail.To.Add(ma);
            //for(int i=0;i<a.Length; i++)
            //mail.To.Add(a[i]);
            mail.IsBodyHtml = true;
            mail.Subject = "Vui lòng xác nhận email của bạn";

            string body = @"<!DOCTYPE html>
                                <body style=""width:100%; height:100%; margin:0; padding:32px; font: normal normal normal 14px/21px Arial,sans-serif; color:#333; background-color:#f1f1f1; -webkit-text-size-adjust:100%; -ms-text-size-adjust:100%;"">
                                    <table class=""email-wrapper"" style=""width:100%; height:100%; margin:auto; padding:0; text-align:center; vertical-align:middle; border-spacing:0; border-collapse:collapse;""><tr><td>
    
                                    <table class=""email-layout"" style=""width:450px; height:300px; margin:auto; padding:0; vertical-align:middle; border-spacing:0; border-collapse:collapse;"">
        
                                        <tbody class=""email-body""><tr><td style=""text-align:left;"">     
                                            <div style=""padding:21px 32px; background-color:#fff; border-bottom:2px solid #e1e1e1; border-radius:3px;"">
                                                <h1 style=""font-size:21px; line-height:30px; font-weight:bold;"">Almost there! Just confirm your email</h1>
                                                <p>
                                                    Please confirm your email to start searching and experimenting on Seven Bridges platform.
                                                </p>
                                                <p style=""padding:11px 0; text-align:left;"">
                                                    <a href=""{{link}}"" target=""_blank"" style=""padding:11px 21px; text-decoration:none; color:#fff !important; background-color:#42af5b; border:1px solid #358d49; border-radius:3px;"">Confirm email</a>
                                                </p>
                                                <p>
                                                    Cheers,<br>
                                                    The Seven Bridges Team
                                                </p>
                                            </div>
                                        </td></tr></tbody>
        
                                        <tfoot class=""email-footer"" style=""text-align:center; font-weight:normal;""><tr><td style=""padding-top:32px;"">
                                            <div style=""color:#999;"">
                                                <a href="""" target=""_blank"" style=""text-decoration:none; color:#446cb3 !important;"">Get in touch</a> |
            <a href="""" target=""_blank"" style=""text-decoration:none; color:#446cb3 !important;"">Knowledge Center</a> |
                                                <a href="""" target=""_blank"" style=""text-decoration:none; color:#446cb3 !important;"">Log in</a>
                                            </div>
                                            <small style=""font-size:12px; color:#999;"">© 2016 Seven Bridges, Inc. 1 Broadway, 14th Floor, Cambridge, MA 02142<small>
                                        </td></tr></tfoot>
                                    </table>
        
                                    </td></tr></table>
                                </body>
                                </html>
                                <!-- partial -->
  
                                </body>
                                </html>
";

            //            body = body.Replace("{{link}}", "https://localhost:44389/Account/Active?code=" + code);
            mail.Body = body;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("thaong22.03@gmail.com", "nguyenthithao");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }
}
