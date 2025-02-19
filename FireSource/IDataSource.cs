﻿using System.Collections;
using System.Collections.Generic;
using Google.Cloud.Firestore;

namespace FireSource
{
    public interface IDataSource
    {
        IEnumerable<Dictionary<string, object>> GetAll();
        Dictionary<string, object> GetById(object KeyValue);
        DocumentReference Add(Dictionary<string, object> obj);
        WriteResult Update(Dictionary<string, object> obj);
        void Delete(object KeyValue);
    }
}
