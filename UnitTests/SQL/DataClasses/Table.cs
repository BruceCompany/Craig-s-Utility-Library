﻿/*
Copyright (c) 2011 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoonUnit.Attributes;
using MoonUnit;
using System.Data;
using Utilities.SQL.DataClasses.Interfaces;

namespace UnitTests.SQL.DataClasses
{
    public class Table
    {
        [Test]
        public void Create()
        {
            Utilities.SQL.DataClasses.Database Database = new Utilities.SQL.DataClasses.Database("TestDatabase");
            Utilities.SQL.DataClasses.Table Table = Database.AddTable("TestTable");
            Assert.Equal(Table, Database.Tables[0]);
            Assert.Equal("TestTable", Table.Name);
        }

        [Test]
        public void AddColumns()
        {
            Utilities.SQL.DataClasses.Database Database = new Utilities.SQL.DataClasses.Database("TestDatabase");
            Utilities.SQL.DataClasses.Table Table = Database.AddTable("TestTable");
            IColumn Column = Table.AddColumn<int>("Column1", DbType.Int32);
            Assert.Equal(Column, Table.Columns[0]);
            Assert.Equal("Column1", Column.Name);
            Assert.Equal(DbType.Int32, Column.DataType);
            Assert.Equal("", Column.Default);
        }
    }
}