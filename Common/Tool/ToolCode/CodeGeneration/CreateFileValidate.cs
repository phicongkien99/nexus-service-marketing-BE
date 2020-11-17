using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonicationMemory.Common;
using CommonicationMemory.Config;
using CommonicationMemory.Properties;

namespace CommonicationMemory.CodeGeneration
{
    public class CreateFileValidate
    {
        public static void GenerateValidateApi(DatabaseTable table, string BusinessLayerRootPath)
        {
            string forderEntity = BusinessLayerRootPath + Path.DirectorySeparatorChar + "ValidateApi\\";
            if (!Directory.Exists(forderEntity))
                Directory.CreateDirectory(forderEntity);

            string file = forderEntity + table.ClassName + "Validate.cs";
            string className = table.ClassName;
            #region Lấy thông tin Entity trong bảng hiện tại (Lấy comment và custom method)
            Dictionary<string, string> dicComment = null;
            Dictionary<string, string> dicFields = null;
            string customMethodString = "";
            string fileCs = ConfigGlobal.SettingConfig.Setting_FoudationLink + "\\ControllerApi\\" + className + "Controller.cs";
            if (!string.IsNullOrEmpty(ConfigGlobal.SettingConfig.Setting_FoudationLink) && ConfigGlobal.SettingConfig.Setting_CheckGenByForder)
            {
                if (File.Exists(fileCs))
                {
                    using (StreamReader streamReader = new StreamReader(fileCs))
                    {
                        string text = streamReader.ReadToEnd();
                        streamReader.Close();
                        dicFields = FindFieldInEntity(text, out dicComment, out customMethodString);
                    }

                    //var streamReader = new StreamReader(fileCs);
                    //string text = streamReader.ReadToEnd();
                    //streamReader.Close();
                    //dicFields = FindFieldInEntity(text, out dicComment, out customMethodString);
                }
            }
            #endregion

            var stringBuild = new StringBuilder();
            {
                #region Header
                stringBuild.AppendLine("using System;");
                stringBuild.AppendLine("using System.Net;");
                stringBuild.AppendLine("using System.Collections.Generic;");
                stringBuild.AppendLine("using System.Linq;");
                stringBuild.AppendLine("using System.Threading.Tasks;");
                stringBuild.AppendLine("using System.Web.Http;");
                stringBuild.AppendLine("using Nexus.Common.Enum;");
                stringBuild.AppendLine("using System.Web.Http.Cors;");
                stringBuild.AppendLine("using Nexus.DatabaseDAL.Common;");
                stringBuild.AppendLine("using Nexus.Entity;");
                stringBuild.AppendLine("using Nexus.Entity.Entities;");
                stringBuild.AppendLine("using Nexus.Memory;");
                stringBuild.AppendLine("using Nexus.Models;");
                stringBuild.AppendLine("using Nexus.Utils;");

                stringBuild.AppendLine("namespace Nexus.ValidateApi");
                stringBuild.AppendLine("{");
                stringBuild.AppendLine("\tpublic class " + className + "Validate");
                stringBuild.AppendFormat("\t{{");
                #endregion

                stringBuild.AppendLine("");
                #region Custom Function
                stringBuild.AppendLine("\t\t#region Validation");
                stringBuild.AppendLine($"\t\tpublic static bool Validate({table.ClassName} obj, out string errorCode, out string errorMess)");
                stringBuild.AppendLine("\t\t{");
                stringBuild.AppendLine("\t\t\terrorCode = null;");
                stringBuild.AppendLine("\t\t\terrorMess = null;");
                stringBuild.AppendLine("\t\t\ttry");
                stringBuild.AppendLine("\t\t\t{");
                stringBuild.AppendLine("\t\t\t\tif (obj == null)");
                stringBuild.AppendLine("\t\t\t\t{");
                stringBuild.AppendLine("\t\t\t\t\terrorCode = ErrorCodeEnum.DataInputWrong.ToString();");
                stringBuild.AppendLine("\t\t\t\t\treturn false;");
                stringBuild.AppendLine("\t\t\t\t}");

                #region Check Properties

                foreach (var column in table.Columns)
                {
                    string columnName = column.PropertyName;
                    if (!column.IsNull && columnName != "Id")
                    {
                        stringBuild.AppendLine($"\t\t\t\tif (obj.{columnName} == null)");
                        stringBuild.AppendLine("\t\t\t\t{");
                        stringBuild.AppendLine("\t\t\t\t\terrorCode = ErrorCodeEnum.DataInputWrong.ToString();");
                        stringBuild.AppendLine($"\t\t\t\t\terrorMess = \"{columnName} not allow null value\";");
                        stringBuild.AppendLine("\t\t\t\t\treturn false;");
                        stringBuild.AppendLine("\t\t\t\t}");
                    }
                }
                

                #endregion
                stringBuild.AppendLine("\t\t\t}");
                stringBuild.AppendLine("\t\t\tcatch (Exception ex)");
                stringBuild.AppendLine("\t\t\t{");
                stringBuild.AppendLine("\t\t\t\tLogger.Write(ex.ToString());");
                stringBuild.AppendLine("\t\t\t\tthrow;");
                stringBuild.AppendLine("\t\t\t}");
                stringBuild.AppendLine("\t\t\treturn true;");
                stringBuild.AppendLine("\t\t}");
                stringBuild.AppendLine("");
                
                stringBuild.AppendLine($"\t\tpublic static bool ValidateUpdate({table.ClassName} obj, out string errorCode, out string errorMess)");
                stringBuild.AppendLine("\t\t{");
                stringBuild.AppendLine("\t\t\terrorCode = null;");
                stringBuild.AppendLine("\t\t\terrorMess = null;");
                stringBuild.AppendLine("\t\t\ttry");
                stringBuild.AppendLine("\t\t\t{");
                stringBuild.AppendLine("\t\t\t\tif (obj == null)");
                stringBuild.AppendLine("\t\t\t\t{");
                stringBuild.AppendLine("\t\t\t\t\terrorCode = ErrorCodeEnum.DataInputWrong.ToString();");
                stringBuild.AppendLine("\t\t\t\t\treturn false;");
                stringBuild.AppendLine("\t\t\t\t}");

                #region Check Properties

                foreach (var column in table.Columns)
                {
                    string columnName = column.PropertyName;
                    if (!column.IsNull && columnName != "Id")
                    {
                        stringBuild.AppendLine($"\t\t\t\tif (obj.{columnName} == null)");
                        stringBuild.AppendLine("\t\t\t\t{");
                        stringBuild.AppendLine("\t\t\t\t\terrorCode = ErrorCodeEnum.DataInputWrong.ToString();");
                        stringBuild.AppendLine($"\t\t\t\t\terrorMess = \"{columnName} not allow null value\";");
                        stringBuild.AppendLine("\t\t\t\t\treturn false;");
                        stringBuild.AppendLine("\t\t\t\t}");
                    }
                }


                #endregion
                stringBuild.AppendLine("\t\t\t}");
                stringBuild.AppendLine("\t\t\tcatch (Exception ex)");
                stringBuild.AppendLine("\t\t\t{");
                stringBuild.AppendLine("\t\t\t\tLogger.Write(ex.ToString());");
                stringBuild.AppendLine("\t\t\t\tthrow;");
                stringBuild.AppendLine("\t\t\t}");
                stringBuild.AppendLine("\t\t\treturn true;");
                stringBuild.AppendLine("\t\t}");
                stringBuild.AppendLine("\t\t#endregion");
                stringBuild.AppendLine("");


                #endregion

                stringBuild.AppendLine("");
                stringBuild.AppendLine("\t}"); // END OF CLASS
                stringBuild.AppendLine("}"); // END OF NAME SPACE
            }

            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(stringBuild.ToString());
                sw.Close();
            }
            
            if (File.Exists(fileCs) && ConfigGlobal.SettingConfig.Setting_CheckGenByForder)
            {
                File.Delete(fileCs);
                using (var sw = new StreamWriter(fileCs))
                {
                    sw.WriteLine(stringBuild.ToString());
                    sw.Close();
                }
            }
        }

        public static Dictionary<string, string> FindFieldInEntity(string fileText,
            out Dictionary<string, string> dicComment, out string customMethodRegion)
        {
            var dicField = new Dictionary<string, string>();
            dicComment = new Dictionary<string, string>();
            customMethodRegion = "";
            try
            {
                if (fileText.Contains("FxDeal"))
                {

                }
                string[] splits = fileText.Split("\r\n".ToCharArray());
                int count = 0;
                bool isBeginCustomMethod = false;
                int countRegionCustomMethod = 0; //Đếm xem có bao nhiêu region cần phải đóng khi isBeginCustomMethod = true;

                if (splits.Length > 0)
                {
                    foreach (string split in splits)
                    {
                        #region Lưu custom method
                        if (string.IsNullOrEmpty(split)) continue;
                        if (split.ToLower().Contains("#region custom method"))
                        {
                            isBeginCustomMethod = true;
                            customMethodRegion = "\t\t#region Custom Method\r\n";
                            continue;
                        }
                        if (isBeginCustomMethod)
                        {
                            if (split.Contains("#region"))
                            {
                                //Mở thêm 1 region trong custom
                                countRegionCustomMethod++;
                            }
                            if (split.Contains("#endregion"))
                            {
                                //Đóng custom method
                                if (countRegionCustomMethod == 0)
                                    isBeginCustomMethod = false;
                                else
                                {
                                    countRegionCustomMethod--; //Giảm bớt 1 lần đóng region
                                }
                            }
                            customMethodRegion += split + "\r\n";
                            continue; //Ko check thông tin khác khi lưu custom method
                        }

                        #endregion

                        count = 0;
                        if (string.IsNullOrEmpty(split)) continue;
                        if (split.Contains("public") &&
                            split.Contains("get") &&
                            split.Contains("set"))
                        {
                            //Bỏ qua các trường không lưu database
                            if (split.Contains("NotSetDb")) continue;

                            if (split.Contains("?"))
                            {

                            }

                            //Xử lý lấy thông tin
                            string result = split.Replace("public ", "").Trim();
                            string[] splitResult = result.Split(" ".ToCharArray());
                            string tenBien = "";
                            string tenField = "";

                            foreach (var text in splitResult)
                            {
                                if (!string.IsNullOrWhiteSpace(text.Trim()))
                                {
                                    count++;
                                    if (count == 1)
                                    {
                                        //Đây là tên biến
                                        tenBien = text.Trim();
                                    }
                                    if (count == 2)
                                    {
                                        //Đây là tên entity field
                                        tenField = text.Trim();
                                        dicField[tenField] = tenBien; //AccountId string
                                    }
                                }
                            }

                            //Lấy thông tin comment
                            if (result.Contains("//"))
                            {
                                int index = result.IndexOf("//", StringComparison.Ordinal);
                                string comment = result.Substring(index, result.Length - index);
                                dicComment[tenField] = comment;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"error" + ex);
            }
            return dicField;
        }
    }
}
