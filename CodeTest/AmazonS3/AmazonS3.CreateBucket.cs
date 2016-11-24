using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;

namespace CodeTest.AmazonS3
{
    
    public partial class AmazonS3
    {
        
        public void CreateBucket(string bucketName)
        {
            

            PutBucketRequest bucketRequest = new PutBucketRequest
            {
                BucketName = bucketName,
                UseClientRegion = true
            };
            PutBucketResponse bucketResp = s3Client.PutBucket(bucketRequest);
            
        }
    }
    
}
