using System;
using System.Collections.Generic;

namespace MstscManage.Class_Modules
{
	internal class ColorValueModel
	{
		public ColorValueModel()
		{
		}

		public ColorValueModel(int value, string name)
		{
			this.Value = value;
			this.Name = name;
		}

		public int Value { get; set; }

		public string Name { get; set; }

		public List<ColorValueModel> GetColorValue()
		{
			return new List<ColorValueModel>
			{
				new ColorValueModel(15, "增强色(15位)"),
				new ColorValueModel(16, "增强色(16位)"),
				new ColorValueModel(24, "真彩色(24位)"),
				new ColorValueModel(32, "最高作量(32位)")
			};
		}
	}
}
