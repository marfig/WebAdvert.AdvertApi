﻿using System;
using AdvertApi.Models;
using Amazon.DynamoDBv2.DataModel;

namespace AdvertApi.Services
{
    [DynamoDBTable("Advert")]
    public class AdvertDbModel
    {
        [DynamoDBHashKey]
        public string Id { get; set; }

        [DynamoDBProperty]
        public string Title { get; set; }

        [DynamoDBProperty]
        public string Description { get; set; }

        [DynamoDBProperty]
        public double Price { get; set; }

        [DynamoDBProperty]
        public DateTime CreatioDateTime { get; set; }

        [DynamoDBProperty]
        public AdvertStatus Status { get; set; }
    }
}
