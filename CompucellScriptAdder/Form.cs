using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections.Generic;

namespace CompucellScriptAdder
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string xmlScriptFilePath = "";
        private string resourceFilePath = "";
        private string pythonScriptFilePath = "";

        public Form()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Simulation Project";
            theDialog.Filter = "CC3D files|*.cc3d";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = theDialog.FileName;
                tbxProjectPath.Text = fileName;
                // Create an XML reader for this file.
                using (XmlReader reader = XmlReader.Create(fileName))
                {
                    while (reader.Read())
                    {
                        // Only detect start elements.
                        if (reader.IsStartElement())
                        {
                            // Get element name and switch on it.
                            switch (reader.Name)
                            {
                                case "XMLScript":
                                    if (reader.Read())
                                    {
                                        xmlScriptFilePath = Path.GetDirectoryName(fileName) + "/" + reader.Value;
                                        //MessageBox.Show(xmlScriptFilePath);
                                    }
                                    break;
                                case "PythonScript":
                                    if (reader.Read())
                                    {
                                        pythonScriptFilePath = Path.GetDirectoryName(fileName) + "/" + reader.Value;
                                        //MessageBox.Show(pythonScriptFilePath);
                                    }
                                    break;
                                case "Resource":
                                    if (reader.GetAttribute("Type") != "Python") break;
                                    if (reader.Read())
                                    {
                                        resourceFilePath = Path.GetDirectoryName(fileName) + "/" + reader.Value;
                                        //MessageBox.Show(resourceFilePath);
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void addXML(string element, string attribute, string value)
        {
            if (xmlScriptFilePath == "")
            {
                MessageBox.Show("There is no xmlScript file.");
                return;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlScriptFilePath);
            XmlNode root = doc.DocumentElement;
            switch(element)
            {
                case "Dimensions":
                    XmlNode node = root.SelectSingleNode("/CompuCell3D/Potts/" + element);
                    if (node != null)
                    {
                        if(node.Attributes[attribute] != null)
                            node.Attributes[attribute].Value = value;
                        else
                        {
                            XmlAttribute typeAttr = doc.CreateAttribute(attribute);
                            typeAttr.Value = value;
                            node.Attributes.Append(typeAttr);
                        }
                            
                    }
                    else
                    {
                        node = root.SelectSingleNode("/CompuCell3D/Potts");
                        if (node == null)
                        {
                            XmlElement potts = doc.CreateElement("Potts");
                            XmlElement child = doc.CreateElement(element);
                            child.SetAttribute(attribute, value);
                            potts.AppendChild(child);
                            root.SelectSingleNode("/CompuCell3D").AppendChild(potts);
                        }
                        else
                        {
                            XmlElement child = doc.CreateElement(element);
                            child.SetAttribute(attribute, value);
                            node.AppendChild(child);
                        }
                    }
                    break;
                case "Anneal":
                case "Steps":
                case "Temperature":
                case "Flip2DimRatio":
                case "NeighborOrder":
                    node = root.SelectSingleNode("/CompuCell3D/Potts/" + element);
                    if (node != null)
                    {
                        node.InnerText = value;
                    }
                    else
                    {
                        node = root.SelectSingleNode("/CompuCell3D/Potts");
                        if (node == null)
                        {
                            XmlElement potts = doc.CreateElement("Potts");
                            XmlElement child = doc.CreateElement(element);
                            child.InnerText = value;
                            potts.AppendChild(child);
                            root.SelectSingleNode("/CompuCell3D").AppendChild(potts);
                        }
                        else
                        {
                            XmlElement child = doc.CreateElement(element);
                            child.InnerText = value;
                            node.AppendChild(child);
                        }
                    }
                    break;
                case "TargetVolume":
                case "LambdaVolume":
                    node = root.SelectSingleNode("/CompuCell3D/Plugin[@Name='Volume']/" + element);
                    if(node != null)
                    {
                        node.InnerText = value;
                    }
                    else
                    {
                        node = root.SelectSingleNode("/CompuCell3D/Plugin[@Name='Volume']");
                        if (node == null)
                        {
                            XmlElement plugin = doc.CreateElement("Plugin");
                            plugin.SetAttribute("Name", "Volume");
                            XmlElement child = doc.CreateElement(element);
                            child.InnerText = value;
                            plugin.AppendChild(child);
                            root.SelectSingleNode("/CompuCell3D").AppendChild(plugin);
                        }
                        else
                        {
                            XmlElement targetVolume = doc.CreateElement(element);
                            targetVolume.InnerText = value;
                            node.AppendChild(targetVolume);
                        }
                    }
                    break;
            }
            doc.Save(xmlScriptFilePath);
        }

        private void addPythonScript(string pythonScript)
        {
            if (pythonScriptFilePath == "")
            {
                MessageBox.Show("There is no PythonScript file.");
                return;
            }

            string filetext = File.ReadAllText(pythonScriptFilePath);
            if (filetext.Contains(pythonScript)) MessageBox.Show("PythonScript already exists.");
            else
            {
                var text = new StringBuilder();
                foreach (string s in File.ReadAllLines(pythonScriptFilePath))
                {
                    text.AppendLine(s.Replace("CompuCellSetup.mainLoop(", pythonScript + "CompuCellSetup.mainLoop("));
                }

                using (var file = new StreamWriter(File.Create(pythonScriptFilePath)))
                {
                    file.Write(text.ToString());
                }
            }
        }

        private void addResource(string fileName, List<InitParameter> paramList)
        {
            if (resourceFilePath == "")
            {
                MessageBox.Show("There is no Resource(Type=Python) file.");
                return;
            }

            try
            {
                /*FileStream stream = new FileStream(fileName, FileMode.Open);

                DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

                cryptic.Key = ASCIIEncoding.ASCII.GetBytes("hiccup19");
                cryptic.IV = ASCIIEncoding.ASCII.GetBytes("hiccup19");

                CryptoStream crStream = new CryptoStream(stream, cryptic.CreateDecryptor(), CryptoStreamMode.Read);

                StreamReader reader = new StreamReader(crStream);*/

                StreamReader reader = new StreamReader(fileName);

                StringBuilder sbText = new StringBuilder();
                string line;
                while (!(line = reader.ReadLine()).Contains("def __init__("))
                {
                    for(int i = 0; i < paramList.Count; i++)
                    {
                        if (line.Contains(paramList[i].name + " = "))
                        {
                            int start = line.IndexOf(" = ") + 3;
                            line = line.Remove(start);
                            line = line.Insert(start, paramList[i].value);
                            paramList.RemoveAt(i);
                            break;
                        }
                    }
                    sbText.AppendLine(line);
                }
                for (int i = 0; i < paramList.Count; i++)
                {
                    sbText.AppendLine(paramList[i].name + '=' + paramList[i].value);
                }
                sbText.AppendLine(line);
                string body = reader.ReadToEnd();
                sbText.Append(body);
                reader.Close();
                //stream.Close();

                string text = File.ReadAllText(resourceFilePath);
                int pos = text.IndexOf(body);
                if (pos != -1)
                {
                    int beginpos = text.LastIndexOf("class ", pos);
                    text = text.Remove(beginpos - 2, pos + body.Length - beginpos + 2);
                }
                File.WriteAllText(resourceFilePath, text + sbText.ToString());
                MessageBox.Show("Successfully Changed.");
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("Error in adding script.");
            }
        }

        private void btnEncrpyt_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Simulation Project";
            theDialog.Filter = "All files|*.*";
            theDialog.InitialDirectory = "E:/mytask/Compucell/CompucellScriptAdder";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = theDialog.FileName;
                try
                {
                    DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

                    cryptic.Key = ASCIIEncoding.ASCII.GetBytes("hiccup19");
                    cryptic.IV = ASCIIEncoding.ASCII.GetBytes("hiccup19");

                    string cryptFile = Path.GetDirectoryName(fileName) + "/" + Path.GetFileNameWithoutExtension(fileName) + ".enc";
                    FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                    CryptoStream cs = new CryptoStream(fsCrypt, cryptic.CreateEncryptor(), CryptoStreamMode.Write);

                    FileStream fsIn = new FileStream(fileName, FileMode.Open);

                    int data;
                    while ((data = fsIn.ReadByte()) != -1)
                        cs.WriteByte((byte)data);

                    fsIn.Close();
                    cs.Close();
                    fsCrypt.Close();
                }
                catch(Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                    MessageBox.Show("Error in encryption.");
                }
            }
        }

        private void btnTemperaturePanel_Click(object sender, EventArgs e)
        {
            addXML("Temperature", "", tbxTemperature.Text);

            string pythonScript = "\r\nfrom " + Path.GetFileNameWithoutExtension(resourceFilePath) + " import TemperatureSteeringSteppable\r\n\r\n" +
                "temperatureSteeringSteppable = TemperatureSteeringSteppable(_simulator = sim, _frequency = 1)\r\n" +
                "steppableRegistry.registerSteppable(temperatureSteeringSteppable)\r\n";
            addPythonScript(pythonScript);

            List<InitParameter> paramList = new List<InitParameter>();
            paramList.Add(new InitParameter() { name = "initInterval", value = tbxInterval.Text });
            paramList.Add(new InitParameter() { name = "initTemperature", value = tbxTemperature.Text });
            //addResource("temperaturepanel.enc", paramList);
            addResource("temperaturepanel.py", paramList);
        }

        private void btnStepsPanel_Click(object sender, EventArgs e)
        {
            addXML("Steps", "", tbxSteps.Text);

            string pythonScript = "\r\nfrom " + Path.GetFileNameWithoutExtension(resourceFilePath) + " import StepsSteeringSteppable\r\n\r\n" +
                "stepsSteeringSteppable = StepsSteeringSteppable(_simulator = sim, _frequency = 1)\r\n" +
                "steppableRegistry.registerSteppable(stepsSteeringSteppable)\r\n";
            addPythonScript(pythonScript);

            List<InitParameter> paramList = new List<InitParameter>();
            paramList.Add(new InitParameter() { name = "steps", value = tbxSteps.Text });
            //addResource("stepspanel.enc", paramList);
            addResource("stepspanel.py", paramList);
        }

        private void btnFlip2DimRatioPanel_Click(object sender, EventArgs e)
        {
            addXML("Flip2DimRatio", "", tbxFlip2DimRatio.Text);

            string pythonScript = "\r\nfrom " + Path.GetFileNameWithoutExtension(resourceFilePath) + " import Flip2DimRatioSteeringSteppable\r\n\r\n" +
                "flip2DimRatioSteeringSteppable = Flip2DimRatioSteeringSteppable(_simulator = sim, _frequency = 1)\r\n" +
                "steppableRegistry.registerSteppable(flip2DimRatioSteeringSteppable)\r\n";
            addPythonScript(pythonScript);

            List<InitParameter> paramList = new List<InitParameter>();
            paramList.Add(new InitParameter() { name = "flip2DimRatio", value = tbxFlip2DimRatio.Text });
            //addResource("flip2dimratiopanel.enc", paramList);
            addResource("flip2dimratiopanel.py", paramList);
        }

        private void btnNeighborOrderPanel_Click(object sender, EventArgs e)
        {
            addXML("NeighborOrder", "", tbxNeighborOrder.Text);

            string pythonScript = "\r\nfrom " + Path.GetFileNameWithoutExtension(resourceFilePath) + " import NeighborOrderSteeringSteppable\r\n\r\n" +
                "neighborOrderSteeringSteppable = NeighborOrderSteeringSteppable(_simulator = sim, _frequency = 1)\r\n" +
                "steppableRegistry.registerSteppable(neighborOrderSteeringSteppable)\r\n";
            addPythonScript(pythonScript);

            List<InitParameter> paramList = new List<InitParameter>();
            paramList.Add(new InitParameter() { name = "neighborOrder", value = tbxNeighborOrder.Text });
            //addResource("neighbororderpanel.enc", paramList);
            addResource("neighbororderpanel.py", paramList);
        }

        private void btnVolumePanel_Click(object sender, EventArgs e)
        {
            addXML("TargetVolume", "", tbxTargetVolume.Text);
            addXML("LambdaVolume", "", tbxLambdaVolume.Text);

            string pythonScript = "\r\nfrom " + Path.GetFileNameWithoutExtension(resourceFilePath) + " import VolumeSteeringSteppable\r\n\r\n" +
                "volumeSteeringSteppable = VolumeSteeringSteppable(_simulator = sim, _frequency = 1)\r\n" +
                "steppableRegistry.registerSteppable(volumeSteeringSteppable)\r\n";
            addPythonScript(pythonScript);

            List<InitParameter> paramList = new List<InitParameter>();
            paramList.Add(new InitParameter() { name = "targetVolume", value = tbxTargetVolume.Text });
            paramList.Add(new InitParameter() { name = "lambdaVolume", value = tbxLambdaVolume.Text });
            //addResource("volumepanel.enc", paramList);
            addResource("volumepanel.py", paramList);
        }

        private void btnDimension_Click(object sender, EventArgs e)
        {
            addXML("Dimensions", "x", tbxInitialX.Text);
            addXML("Dimensions", "y", tbxInitialY.Text);
            addXML("Dimensions", "z", tbxInitialZ.Text);
            MessageBox.Show("Successfully changed.");
        }
    }

    class InitParameter
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}

