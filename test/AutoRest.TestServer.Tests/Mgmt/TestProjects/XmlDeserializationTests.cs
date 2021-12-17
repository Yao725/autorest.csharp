﻿using System;
using System.Reflection;
using System.Text.Json;
using System.Xml.Linq;
using NUnit.Framework;
using Azure.Core;
using XmlDeserialization;
using XmlDeserialization.Models;
using SingletonResource;

namespace AutoRest.TestServer.Tests.Mgmt.TestProjects
{
    public class XmlDeserializationTests : TestProjectTests
    {
        public XmlDeserializationTests()
            : base("XmlDeserialization") { }

        [Test]
        public void ValidateMgmtXmlDeserialization()
        {
            string id = "/subscriptions/27af6a7d-4b66-4d59-8786-0999a97b32b9/resourceGroups/testRg/providers/Microsoft.XmlDeserialization/xmls/fakeXml";
            string name = "fakeXml";
            string type = "Microsoft.XmlDeserialization/xmls";
            XElement xElement = new XElement("XmlInstance",
                new XElement("id", id),
                new XElement("name", name),
                new XElement("type", type)
            );
            XmlInstanceData xmlInstanceData = XmlInstanceData.DeserializeXmlInstanceData(xElement);
            Assert.AreEqual(id, xmlInstanceData.Id.ToString());
            Assert.AreEqual(name, xmlInstanceData.Name);
            Assert.AreEqual(type, xmlInstanceData.Type.ToString());

            string wrongId = "/subscriptions/testSub/resourceGroups/testRg/providers/Microsoft.XmlDeserialization/xmls/fakeXml";
            xElement.SetElementValue("id", wrongId);
            Assert.Throws<ArgumentOutOfRangeException>(() => XmlInstanceData.DeserializeXmlInstanceData(xElement));

            string wrongType = "";
            xElement.SetElementValue("id", id);
            xElement.SetElementValue("type", wrongType);
            Assert.Throws<ArgumentException>(() => XmlInstanceData.DeserializeXmlInstanceData(xElement));
        }
    }
}
