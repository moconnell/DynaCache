#region Copyright 2012 Mike Goatly
// This source is subject to the the MIT License (MIT)
// All rights reserved.
#endregion

namespace DynaCache.Tests.TestClasses
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// A test class that has no cacheable methods defined within it.
	/// </summary>
	public class NoCacheableMethodsTester : ICacheableMethodsTester
	{
		public void Execute()
		{
		}

		public int Execute(DateTime data)
		{
			return 11;
		}

		public string[] Execute(string data)
		{
			return new[] { data };
		}

		public List<string> Execute(int data1, object data2)
		{
			return new List<string> { data1.ToString(), data2.ToString() };
		}
	}
}