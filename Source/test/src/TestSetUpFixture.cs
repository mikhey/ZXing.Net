﻿/*
 * Copyright 2013 ZXing.Net authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using NUnit.Framework;

namespace ZXing
{
   [SetUpFixture]
   public class TestSetUpFixture
   {
      [OneTimeSetUp]
      public void SetUp()
      {
         if (System.IO.File.Exists("log4net.config"))
         {
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
         }
      }
   }
}
