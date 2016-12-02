﻿// ==========================================================================
//  MongoAppClientKeyEntity.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using System;
using MongoDB.Bson.Serialization.Attributes;
using Squidex.Read.Apps;

namespace Squidex.Store.MongoDb.Apps
{
    public sealed class MongoAppClientEntity : IAppClientEntity
    {
        [BsonRequired]
        [BsonElement]
        public string ClientId { get; set; }

        [BsonRequired]
        [BsonElement]
        public string ClientSecret { get; set; }

        [BsonRequired]
        [BsonElement]
        public DateTime ExpiresUtc { get; set; }

        [BsonRequired]
        [BsonElement]
        public string Name { get; set; }
    }
}