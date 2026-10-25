// 本文件由反编译碎片合并生成，包含以下原始文件的全部类型定义：
//   - AspMvcActionAttribute.cs
//   - AspMvcActionSelectorAttribute.cs
//   - AspMvcAreaAttribute.cs
//   - AspMvcControllerAttribute.cs
//   - AspMvcDisplayTemplateAttribute.cs
//   - AspMvcEditorTemplateAttribute.cs
//   - AspMvcMasterAttribute.cs
//   - AspMvcModelTypeAttribute.cs
//   - AspMvcPartialViewAttribute.cs
//   - AspMvcSupressViewErrorAttribute.cs
//   - AspMvcTemplateAttribute.cs
//   - AspMvcViewAttribute.cs
//   - BaseTypeRequiredAttribute.cs
//   - CanBeNullAttribute.cs
//   - CannotApplyEqualityOperatorAttribute.cs
//   - ContractAnnotationAttribute.cs
//   - HtmlAttributeValueAttribute.cs
//   - HtmlElementAttributesAttribute.cs
//   - ImplicitUseKindFlags.cs
//   - ImplicitUseTargetFlags.cs
//   - InstantHandleAttribute.cs
//   - InvokerParameterNameAttribute.cs
//   - LocalizationRequiredAttribute.cs
//   - MeansImplicitUseAttribute.cs
//   - NotifyPropertyChangedInvocatorAttribute.cs
//   - NotNullAttribute.cs
//   - PathReferenceAttribute.cs
//   - PublicAPIAttribute.cs
//   - PureAttribute.cs
//   - RazorSectionAttribute.cs
//   - StringFormatMethodAttribute.cs
//   - UsedImplicitlyAttribute.cs

using System;

namespace System.FishExtension
{
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	public sealed class AspMvcActionAttribute : Attribute
	{
		public AspMvcActionAttribute()
		{
		}

		public AspMvcActionAttribute([NotNull] string anonymousProperty)
		{
			this.AnonymousProperty = anonymousProperty;
		}

		[NotNull]
		public string AnonymousProperty { get; private set; }
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
	public sealed class AspMvcActionSelectorAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class AspMvcAreaAttribute : PathReferenceAttribute
	{
		public AspMvcAreaAttribute()
		{
		}

		public AspMvcAreaAttribute([NotNull] string anonymousProperty)
		{
			this.AnonymousProperty = anonymousProperty;
		}

		[NotNull]
		public string AnonymousProperty { get; private set; }
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	public sealed class AspMvcControllerAttribute : Attribute
	{
		public AspMvcControllerAttribute()
		{
		}

		public AspMvcControllerAttribute([NotNull] string anonymousProperty)
		{
			this.AnonymousProperty = anonymousProperty;
		}

		[NotNull]
		public string AnonymousProperty { get; private set; }
	}

	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class AspMvcDisplayTemplateAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class AspMvcEditorTemplateAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class AspMvcMasterAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class AspMvcModelTypeAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	public sealed class AspMvcPartialViewAttribute : PathReferenceAttribute
	{
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public sealed class AspMvcSupressViewErrorAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class AspMvcTemplateAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	public sealed class AspMvcViewAttribute : PathReferenceAttribute
	{
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	[BaseTypeRequired(typeof(Attribute))]
	public sealed class BaseTypeRequiredAttribute : Attribute
	{
		public BaseTypeRequiredAttribute([NotNull] Type baseType)
		{
			this.BaseType = baseType;
		}

		[NotNull]
		public Type BaseType { get; private set; }
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = false, Inherited = true)]
	public sealed class CanBeNullAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	public sealed class CannotApplyEqualityOperatorAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	public sealed class ContractAnnotationAttribute : Attribute
	{
		public ContractAnnotationAttribute([NotNull] string contract) : this(contract, false)
		{
		}

		public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
		{
			this.Contract = contract;
			this.ForceFullStates = forceFullStates;
		}

		public string Contract { get; private set; }

		public bool ForceFullStates { get; private set; }
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, Inherited = true)]
	public sealed class HtmlAttributeValueAttribute : Attribute
	{
		public HtmlAttributeValueAttribute([NotNull] string name)
		{
			this.Name = name;
		}

		[NotNull]
		public string Name { get; private set; }
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, Inherited = true)]
	public sealed class HtmlElementAttributesAttribute : Attribute
	{
		public HtmlElementAttributesAttribute()
		{
		}

		public HtmlElementAttributesAttribute([NotNull] string name)
		{
			this.Name = name;
		}

		[NotNull]
		public string Name { get; private set; }
	}

	[Flags]
	public enum ImplicitUseKindFlags
	{
		Default = 7,
		Access = 1,
		Assign = 2,
		InstantiatedWithFixedConstructorSignature = 4,
		InstantiatedNoFixedConstructorSignature = 8
	}

	[Flags]
	public enum ImplicitUseTargetFlags
	{
		Default = 1,
		Itself = 1,
		Members = 2,
		WithMembers = 3
	}

	[AttributeUsage(AttributeTargets.Parameter, Inherited = true)]
	public sealed class InstantHandleAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
	public sealed class InvokerParameterNameAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class LocalizationRequiredAttribute : Attribute
	{
		public LocalizationRequiredAttribute() : this(true)
		{
		}

		public LocalizationRequiredAttribute(bool required)
		{
			this.Required = required;
		}

		public bool Required { get; private set; }
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class MeansImplicitUseAttribute : Attribute
	{
		public MeansImplicitUseAttribute() : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
		{
		}

		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags) : this(useKindFlags, ImplicitUseTargetFlags.Default)
		{
		}

		public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags) : this(ImplicitUseKindFlags.Default, targetFlags)
		{
		}

		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
			this.UseKindFlags = useKindFlags;
			this.TargetFlags = targetFlags;
		}

		[UsedImplicitly]
		public ImplicitUseKindFlags UseKindFlags { get; private set; }

		[UsedImplicitly]
		public ImplicitUseTargetFlags TargetFlags { get; private set; }
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
	{
		public NotifyPropertyChangedInvocatorAttribute()
		{
		}

		public NotifyPropertyChangedInvocatorAttribute(string parameterName)
		{
			this.ParameterName = parameterName;
		}

		public string ParameterName { get; private set; }
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = false, Inherited = true)]
	public sealed class NotNullAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Parameter)]
	public class PathReferenceAttribute : Attribute
	{
		public PathReferenceAttribute()
		{
		}

		public PathReferenceAttribute([PathReference] string basePath)
		{
			this.BasePath = basePath;
		}

		[NotNull]
		public string BasePath { get; private set; }
	}

	[MeansImplicitUse]
	public sealed class PublicAPIAttribute : Attribute
	{
		public PublicAPIAttribute()
		{
		}

		public PublicAPIAttribute([NotNull] string comment)
		{
			this.Comment = comment;
		}

		[NotNull]
		public string Comment { get; private set; }
	}

	[AttributeUsage(AttributeTargets.Method, Inherited = true)]
	public sealed class PureAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, Inherited = true)]
	public sealed class RazorSectionAttribute : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public sealed class StringFormatMethodAttribute : Attribute
	{
		public StringFormatMethodAttribute(string formatParameterName)
		{
			this.FormatParameterName = formatParameterName;
		}

		public string FormatParameterName { get; private set; }
	}

	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class UsedImplicitlyAttribute : Attribute
	{
		public UsedImplicitlyAttribute() : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
		{
		}

		public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags) : this(useKindFlags, ImplicitUseTargetFlags.Default)
		{
		}

		public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags) : this(ImplicitUseKindFlags.Default, targetFlags)
		{
		}

		public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
			this.UseKindFlags = useKindFlags;
			this.TargetFlags = targetFlags;
		}

		public ImplicitUseKindFlags UseKindFlags { get; private set; }

		public ImplicitUseTargetFlags TargetFlags { get; private set; }
	}

}
