using System;
namespace Practice1.Models
{
	public class ServiceModel
    {
        public ServiceModel(string task, string image, string id) {

            this.TaskName = task;
            this.ImageUrl = image;
            this.Id = id;
        }
        public string TaskName { get; set; }
        public string ImageUrl { get; set; }

        public string Id { get; set; }
    }
}

