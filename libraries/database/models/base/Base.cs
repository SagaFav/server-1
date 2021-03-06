﻿using System.Xml.Serialization;
using System.Collections.Generic;

using Libraries.helpers.xml;


namespace Libraries.database.models
{

    public class ModelBase
    {

        /// <summary>
        /// Base model
        /// </summary>

        [XmlIgnore]
        public string ToXml
        {

            get
            {

                return XMLHelper.SerializeObjectToXml(this);

            }

        }
        
    }

}
