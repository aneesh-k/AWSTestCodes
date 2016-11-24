using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.EC2;
using Amazon.EC2.Model;
using System.IO;

namespace CodeTest.AmazonEC2
{
    public partial class AmazonEC2
    {
        public void CreateKeyPair(string keyName, string fileName, string filePath)
        {
            AmazonEC2Client ec2 = new AmazonEC2Client();
            
            CreateKeyPairRequest keyReq = new CreateKeyPairRequest();
            keyReq.KeyName = "DevKey";
            
            CreateKeyPairResponse keyResp = ec2.CreateKeyPair(keyReq);
            
            var keyvalue1 = keyResp.KeyPair.KeyFingerprint;
            
            var k2 = keyResp.KeyPair.KeyMaterial;
            
            var k3 = keyResp.KeyPair.KeyName;
           
            string str = keyvalue1 + k2 + k3;
            
            using (FileStream fs = new FileStream(filePath + @"\" + fileName, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(str);
            }
        }
    }
}
