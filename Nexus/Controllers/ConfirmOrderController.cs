﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;
using Nexus.Common.Enum;
using Nexus.DatabaseDAL.Common;
using Nexus.Entity;
using Nexus.Memory;
using Nexus.Utils;

namespace Nexus.Controllers
{
    public class ConfirmOrderController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage  Get(string req)
        {
            try
            {
                var path = AppGlobal.GetAppPath() + AppGlobal.DEFAULT_FOLDER_CONFIG + "TemplateConfirmOrder.html";
                string Html = File.ReadAllText(path);
                if (req == null)
                {
                    Html = Html.Replace("#title", "Sorry!");
                    Html = Html.Replace("#content", "There was a problem during auto-order verification, please contact administrator for processing.");
                }
                else
                {
                    var cfOrderObj = EmailUtils.StringToConfirmOrder(req);
                    if (cfOrderObj == null)
                    {
                        Html = Html.Replace("#title", "Sorry!");
                        Html = Html.Replace("#content", "There was a problem during auto-order verification, please contact administrator for processing.");
                    }
                    else
                    {
                        var orderDetail = MemoryInfo.GetOrderDetail(cfOrderObj.OrderId);
                        if (orderDetail == null)
                        {
                            Html = Html.Replace("#title", "Sorry!");
                            Html = Html.Replace("#content", "There was a problem during auto-order verification, please contact administrator for processing.");
                        }
                        else
                        {
                            // xu li cap nhap trang thai lenh
                            orderDetail.OrderStatus = OrderStatus.Approval.ToString();
                            UpdateEntitySql updateEntitySql = new UpdateEntitySql();
                            var lstCommand = new List<EntityCommand>();
                            lstCommand.Add(new EntityCommand { BaseEntity = new Entity.Entity(orderDetail), EntityAction = EntityAction.Update });
                            bool isOkDone = updateEntitySql.UpdateDefault(lstCommand);
                            if (!isOkDone)
                            {
                                Html = Html.Replace("#title", "Sorry!");
                                Html = Html.Replace("#content", "There was a problem during auto-order verification, please contact administrator for processing.");
                            }
                            else
                            {
                                // update memory
                                MemorySet.UpdateAndInsertEntity(orderDetail);
                                Html = Html.Replace("#title", "Great!");
                                Html = Html.Replace("#content", "Confirm Order Succces!");
                            }
                        }
                    }
                }
                StringBuilder sb = new StringBuilder(Html);
                var response = new HttpResponseMessage();
                response.Content = new StringContent(sb.ToString());
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
                response.ReasonPhrase = "success";
                // what code should i write here
                return response;
            }
            catch (Exception ex)
            {
                Logger.Write(ex.ToString());
            }

            return null;
        }

       

    }
}

