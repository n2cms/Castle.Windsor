// Copyright 2004-2010 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.MicroKernel.Util
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	[Serializable]
	public class ReferenceEqualityComparer : IEqualityComparer, IEqualityComparer<object>
	{
		private static readonly ReferenceEqualityComparer instance = new ReferenceEqualityComparer();

		private ReferenceEqualityComparer()
		{
		}

		bool IEqualityComparer.Equals(object x, object y)
		{
			return ReferenceEquals(x, y);
		}

		public int GetHashCode(object obj)
		{
			return obj.GetHashCode();
		}

		bool IEqualityComparer<object>.Equals(object x, object y)
		{
			return ReferenceEquals(x, y);
		}

		int IEqualityComparer<object>.GetHashCode(object obj)
		{
			return obj.GetHashCode();
		}

		public static ReferenceEqualityComparer Instance
		{
			get { return instance; }
		}
	}
}