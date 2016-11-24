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
        public void DeleteBucket(string bucketName, string bucketKey=null)
        {
              

            #region Delete Bucket Policy
            DeleteBucketPolicyResponse delBucketResp = new DeleteBucketPolicyResponse();
            Console.WriteLine("Bucket policy del -1");
            delBucketResp = s3Client.DeleteBucketPolicy(bucketName);
            Console.WriteLine("Bucket policy del -2");
            Console.WriteLine("s3Client");
            #endregion
            if (bucketKey != null)
            {
                GetObjectRequest getObjectRequest = new GetObjectRequest();
                getObjectRequest.BucketName = bucketName;
                getObjectRequest.Key = bucketKey;

                // GetObjectResponse getObjectResponse = s3Client.GetObject(getObjectRequest);

                DeleteObjectResponse deleteObjectResponse = s3Client.DeleteObject(bucketName, bucketKey);
            }
            #region Delete Bucket Request
            DeleteBucketRequest req = new DeleteBucketRequest();
            Console.WriteLine("Req");
            req.BucketName = bucketName;
            Console.WriteLine(bucketName);
            req.UseClientRegion = true;
            #endregion


            #region Delete Bucket Responce
            DeleteBucketResponse resp = s3Client.DeleteBucket(req);
            Console.WriteLine("Bucket deleted");
            #endregion

        }
    }
}
