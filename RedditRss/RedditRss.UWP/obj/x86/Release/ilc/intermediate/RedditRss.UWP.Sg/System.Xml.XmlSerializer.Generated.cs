extern alias System_Runtime_Extensions;
namespace System.Runtime.CompilerServices {
    internal class __BlockReflectionAttribute : Attribute { }
}

namespace Microsoft.Xml.Serialization.GeneratedAssembly {


    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write70_feed(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"http://www.w3.org/2005/Atom";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"feed", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace1 = ( parentCompileTimeNs == @"http://www.w3.org/2005/Atom" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2005/Atom";
            Write7_Feed(@"feed", namespace1, ((global::RedditRss.Models.Feed)o), true, false, namespace1, @"http://www.w3.org/2005/Atom");
        }

        public void Write71_anyType(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"anyType", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace2 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write1_Object(@"anyType", namespace2, ((global::System.Object)o), true, false, namespace2, @"");
        }

        public void Write72_schema(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"http://www.w3.org/2001/XMLSchema";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"schema", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace3 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write69_XmlSchema(@"schema", namespace3, ((global::System.Xml.Schema.XmlSchema)o), true, false, namespace3, @"http://www.w3.org/2001/XMLSchema");
        }

        public void Write73_anyType(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"anyType", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace4 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write1_Object(@"anyType", namespace4, ((global::System.Object)o), true, false, namespace4, @"");
        }

        void Write1_Object(string n, string ns, global::System.Object o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Object)) {
                }
                else {
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaObject)) {
                        Write8_XmlSchemaObject(n, ns,(global::System.Xml.Schema.XmlSchemaObject)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAnnotated)) {
                        Write17_XmlSchemaAnnotated(n, ns,(global::System.Xml.Schema.XmlSchemaAnnotated)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaNotation)) {
                        Write68_XmlSchemaNotation(n, ns,(global::System.Xml.Schema.XmlSchemaNotation)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaGroup)) {
                        Write66_XmlSchemaGroup(n, ns,(global::System.Xml.Schema.XmlSchemaGroup)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaXPath)) {
                        Write52_XmlSchemaXPath(n, ns,(global::System.Xml.Schema.XmlSchemaXPath)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaIdentityConstraint)) {
                        Write53_XmlSchemaIdentityConstraint(n, ns,(global::System.Xml.Schema.XmlSchemaIdentityConstraint)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaUnique)) {
                        Write56_XmlSchemaUnique(n, ns,(global::System.Xml.Schema.XmlSchemaUnique)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaKeyref)) {
                        Write55_XmlSchemaKeyref(n, ns,(global::System.Xml.Schema.XmlSchemaKeyref)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaKey)) {
                        Write54_XmlSchemaKey(n, ns,(global::System.Xml.Schema.XmlSchemaKey)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaParticle)) {
                        Write49_XmlSchemaParticle(n, ns,(global::System.Xml.Schema.XmlSchemaParticle)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAny)) {
                        Write58_XmlSchemaAny(n, ns,(global::System.Xml.Schema.XmlSchemaAny)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaElement)) {
                        Write57_XmlSchemaElement(n, ns,(global::System.Xml.Schema.XmlSchemaElement)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaGroupBase)) {
                        Write51_XmlSchemaGroupBase(n, ns,(global::System.Xml.Schema.XmlSchemaGroupBase)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAll)) {
                        Write61_XmlSchemaAll(n, ns,(global::System.Xml.Schema.XmlSchemaAll)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSequence)) {
                        Write59_XmlSchemaSequence(n, ns,(global::System.Xml.Schema.XmlSchemaSequence)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaChoice)) {
                        Write60_XmlSchemaChoice(n, ns,(global::System.Xml.Schema.XmlSchemaChoice)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaGroupRef)) {
                        Write50_XmlSchemaGroupRef(n, ns,(global::System.Xml.Schema.XmlSchemaGroupRef)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaContent)) {
                        Write45_XmlSchemaContent(n, ns,(global::System.Xml.Schema.XmlSchemaContent)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContentExtension)) {
                        Write63_Item(n, ns,(global::System.Xml.Schema.XmlSchemaComplexContentExtension)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContentRestriction)) {
                        Write62_Item(n, ns,(global::System.Xml.Schema.XmlSchemaComplexContentRestriction)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContentExtension)) {
                        Write47_Item(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleContentExtension)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContentRestriction)) {
                        Write46_Item(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleContentRestriction)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaContentModel)) {
                        Write44_XmlSchemaContentModel(n, ns,(global::System.Xml.Schema.XmlSchemaContentModel)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContent)) {
                        Write64_XmlSchemaComplexContent(n, ns,(global::System.Xml.Schema.XmlSchemaComplexContent)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContent)) {
                        Write48_XmlSchemaSimpleContent(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleContent)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAnyAttribute)) {
                        Write42_XmlSchemaAnyAttribute(n, ns,(global::System.Xml.Schema.XmlSchemaAnyAttribute)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAttributeGroupRef)) {
                        Write40_XmlSchemaAttributeGroupRef(n, ns,(global::System.Xml.Schema.XmlSchemaAttributeGroupRef)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaFacet)) {
                        Write20_XmlSchemaFacet(n, ns,(global::System.Xml.Schema.XmlSchemaFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet)) {
                        Write33_XmlSchemaWhiteSpaceFacet(n, ns,(global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMinExclusiveFacet)) {
                        Write30_XmlSchemaMinExclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMinExclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMinInclusiveFacet)) {
                        Write29_XmlSchemaMinInclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMinInclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet)) {
                        Write28_XmlSchemaMaxExclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet)) {
                        Write27_XmlSchemaMaxInclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaEnumerationFacet)) {
                        Write26_XmlSchemaEnumerationFacet(n, ns,(global::System.Xml.Schema.XmlSchemaEnumerationFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaPatternFacet)) {
                        Write25_XmlSchemaPatternFacet(n, ns,(global::System.Xml.Schema.XmlSchemaPatternFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaNumericFacet)) {
                        Write21_XmlSchemaNumericFacet(n, ns,(global::System.Xml.Schema.XmlSchemaNumericFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaFractionDigitsFacet)) {
                        Write32_XmlSchemaFractionDigitsFacet(n, ns,(global::System.Xml.Schema.XmlSchemaFractionDigitsFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaTotalDigitsFacet)) {
                        Write31_XmlSchemaTotalDigitsFacet(n, ns,(global::System.Xml.Schema.XmlSchemaTotalDigitsFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxLengthFacet)) {
                        Write24_XmlSchemaMaxLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMaxLengthFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMinLengthFacet)) {
                        Write23_XmlSchemaMinLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMinLengthFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaLengthFacet)) {
                        Write22_XmlSchemaLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaLengthFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeContent)) {
                        Write19_XmlSchemaSimpleTypeContent(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeContent)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeUnion)) {
                        Write36_XmlSchemaSimpleTypeUnion(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeUnion)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeList)) {
                        Write35_XmlSchemaSimpleTypeList(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeList)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction)) {
                        Write34_XmlSchemaSimpleTypeRestriction(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaType)) {
                        Write18_XmlSchemaType(n, ns,(global::System.Xml.Schema.XmlSchemaType)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexType)) {
                        Write65_XmlSchemaComplexType(n, ns,(global::System.Xml.Schema.XmlSchemaComplexType)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleType)) {
                        Write37_XmlSchemaSimpleType(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleType)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAttribute)) {
                        Write39_XmlSchemaAttribute(n, ns,(global::System.Xml.Schema.XmlSchemaAttribute)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAttributeGroup)) {
                        Write43_XmlSchemaAttributeGroup(n, ns,(global::System.Xml.Schema.XmlSchemaAttributeGroup)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAppInfo)) {
                        Write13_XmlSchemaAppInfo(n, ns,(global::System.Xml.Schema.XmlSchemaAppInfo)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaDocumentation)) {
                        Write12_XmlSchemaDocumentation(n, ns,(global::System.Xml.Schema.XmlSchemaDocumentation)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAnnotation)) {
                        Write14_XmlSchemaAnnotation(n, ns,(global::System.Xml.Schema.XmlSchemaAnnotation)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaExternal)) {
                        Write11_XmlSchemaExternal(n, ns,(global::System.Xml.Schema.XmlSchemaExternal)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaRedefine)) {
                        Write67_XmlSchemaRedefine(n, ns,(global::System.Xml.Schema.XmlSchemaRedefine)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaImport)) {
                        Write16_XmlSchemaImport(n, ns,(global::System.Xml.Schema.XmlSchemaImport)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaInclude)) {
                        Write15_XmlSchemaInclude(n, ns,(global::System.Xml.Schema.XmlSchemaInclude)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchema)) {
                        Write69_XmlSchema(n, ns,(global::System.Xml.Schema.XmlSchema)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::RedditRss.Models.Feed)) {
                        Write7_Feed(n, ns,(global::RedditRss.Models.Feed)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::RedditRss.Models.Entry)) {
                        Write6_Entry(n, ns,(global::RedditRss.Models.Entry)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::RedditRss.Models.Link)) {
                        Write5_Link(n, ns,(global::RedditRss.Models.Link)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::RedditRss.Models.Content)) {
                        Write4_Content(n, ns,(global::RedditRss.Models.Content)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::RedditRss.Models.Category)) {
                        Write3_Category(n, ns,(global::RedditRss.Models.Category)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::RedditRss.Models.Author)) {
                        Write2_Author(n, ns,(global::RedditRss.Models.Author)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaForm)) {
                        Writer.WriteStartElement(n, ns);
                        WriteXsiType(@"XmlSchemaForm", @"http://www.w3.org/2001/XMLSchema");
                        Writer.WriteString(Write9_XmlSchemaForm((global::System.Xml.Schema.XmlSchemaForm)o));
                        Writer.WriteEndElement();
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaDerivationMethod)) {
                        Writer.WriteStartElement(n, ns);
                        WriteXsiType(@"XmlSchemaDerivationMethod", @"http://www.w3.org/2001/XMLSchema");
                        Writer.WriteString(Write10_XmlSchemaDerivationMethod((global::System.Xml.Schema.XmlSchemaDerivationMethod)o));
                        Writer.WriteEndElement();
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaUse)) {
                        Writer.WriteStartElement(n, ns);
                        WriteXsiType(@"XmlSchemaUse", @"http://www.w3.org/2001/XMLSchema");
                        Writer.WriteString(Write38_XmlSchemaUse((global::System.Xml.Schema.XmlSchemaUse)o));
                        Writer.WriteEndElement();
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaContentProcessing)) {
                        Writer.WriteStartElement(n, ns);
                        WriteXsiType(@"XmlSchemaContentProcessing", @"http://www.w3.org/2001/XMLSchema");
                        Writer.WriteString(Write41_XmlSchemaContentProcessing((global::System.Xml.Schema.XmlSchemaContentProcessing)o));
                        Writer.WriteEndElement();
                        return;
                    }
                    WriteTypedPrimitive(n, ns, o, true);
                    return;
                }
            }
            WriteStartElement(n, ns, o, false, null);
            WriteEndElement(o);
        }

        string Write41_XmlSchemaContentProcessing(global::System.Xml.Schema.XmlSchemaContentProcessing v) {
            string parentRuntimeNs = null;
            string parentCompileTimeNs = null;
            string s = null;
            switch (v) {
                case global::System.Xml.Schema.XmlSchemaContentProcessing.@Skip: s = @"skip"; break;
                case global::System.Xml.Schema.XmlSchemaContentProcessing.@Lax: s = @"lax"; break;
                case global::System.Xml.Schema.XmlSchemaContentProcessing.@Strict: s = @"strict"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"System.Xml.Schema.XmlSchemaContentProcessing");
            }
            return s;
        }

        string Write38_XmlSchemaUse(global::System.Xml.Schema.XmlSchemaUse v) {
            string parentRuntimeNs = null;
            string parentCompileTimeNs = null;
            string s = null;
            switch (v) {
                case global::System.Xml.Schema.XmlSchemaUse.@Optional: s = @"optional"; break;
                case global::System.Xml.Schema.XmlSchemaUse.@Prohibited: s = @"prohibited"; break;
                case global::System.Xml.Schema.XmlSchemaUse.@Required: s = @"required"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"System.Xml.Schema.XmlSchemaUse");
            }
            return s;
        }

        string Write10_XmlSchemaDerivationMethod(global::System.Xml.Schema.XmlSchemaDerivationMethod v) {
            string parentRuntimeNs = null;
            string parentCompileTimeNs = null;
            string s = null;
            switch (v) {
                case global::System.Xml.Schema.XmlSchemaDerivationMethod.@Empty: s = @""; break;
                case global::System.Xml.Schema.XmlSchemaDerivationMethod.@Substitution: s = @"substitution"; break;
                case global::System.Xml.Schema.XmlSchemaDerivationMethod.@Extension: s = @"extension"; break;
                case global::System.Xml.Schema.XmlSchemaDerivationMethod.@Restriction: s = @"restriction"; break;
                case global::System.Xml.Schema.XmlSchemaDerivationMethod.@List: s = @"list"; break;
                case global::System.Xml.Schema.XmlSchemaDerivationMethod.@Union: s = @"union"; break;
                case global::System.Xml.Schema.XmlSchemaDerivationMethod.@All: s = @"#all"; break;
                default: s = FromEnum(((System.Int64)v), new string[] {@"", 
                    @"substitution", 
                    @"extension", 
                    @"restriction", 
                    @"list", 
                    @"union", 
                    @"#all"}, new System.Int64[] {(long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@Empty, 
                    (long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@Substitution, 
                    (long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@Extension, 
                    (long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@Restriction, 
                    (long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@List, 
                    (long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@Union, 
                    (long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@All}, @"System.Xml.Schema.XmlSchemaDerivationMethod"); break;
            }
            return s;
        }

        string Write9_XmlSchemaForm(global::System.Xml.Schema.XmlSchemaForm v) {
            string parentRuntimeNs = null;
            string parentCompileTimeNs = null;
            string s = null;
            switch (v) {
                case global::System.Xml.Schema.XmlSchemaForm.@Qualified: s = @"qualified"; break;
                case global::System.Xml.Schema.XmlSchemaForm.@Unqualified: s = @"unqualified"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"System.Xml.Schema.XmlSchemaForm");
            }
            return s;
        }

        void Write2_Author(string n, string ns, global::RedditRss.Models.Author o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::RedditRss.Models.Author)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Author", defaultNamespace);
            string namespace5 = ( parentCompileTimeNs == @"http://www.w3.org/2005/Atom" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2005/Atom";
            WriteElementString(@"name", namespace5, ((global::System.String)o.@Name));
            string namespace6 = ( parentCompileTimeNs == @"http://www.w3.org/2005/Atom" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2005/Atom";
            WriteElementString(@"uri", namespace6, ((global::System.String)o.@Uri));
            WriteEndElement(o);
        }

        void Write3_Category(string n, string ns, global::RedditRss.Models.Category o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::RedditRss.Models.Category)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Category", defaultNamespace);
            WriteAttribute(@"term", @"", ((global::System.String)o.@Term));
            WriteAttribute(@"label", @"", ((global::System.String)o.@Label));
            WriteEndElement(o);
        }

        void Write4_Content(string n, string ns, global::RedditRss.Models.Content o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::RedditRss.Models.Content)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Content", defaultNamespace);
            WriteAttribute(@"type", @"", ((global::System.String)o.@Type));
            if ((object)(o.@Text) != null){
                WriteValue(((global::System.String)o.@Text));
            }
            WriteEndElement(o);
        }

        void Write5_Link(string n, string ns, global::RedditRss.Models.Link o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::RedditRss.Models.Link)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Link", defaultNamespace);
            WriteAttribute(@"rel", @"", ((global::System.String)o.@Rel));
            WriteAttribute(@"href", @"", ((global::System.String)o.@Href));
            WriteAttribute(@"type", @"", ((global::System.String)o.@Type));
            WriteEndElement(o);
        }

        void Write6_Entry(string n, string ns, global::RedditRss.Models.Entry o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::RedditRss.Models.Entry)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Entry", defaultNamespace);
            string namespace7 = ( parentCompileTimeNs == @"http://www.w3.org/2005/Atom" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2005/Atom";
            Write2_Author(@"author", namespace7, ((global::RedditRss.Models.Author)o.@Author), false, false, namespace7, @"http://www.w3.org/2005/Atom");
            string namespace8 = ( parentCompileTimeNs == @"http://www.w3.org/2005/Atom" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2005/Atom";
            Write3_Category(@"category", namespace8, ((global::RedditRss.Models.Category)o.@Category), false, false, namespace8, @"http://www.w3.org/2005/Atom");
            string namespace9 = ( parentCompileTimeNs == @"http://www.w3.org/2005/Atom" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2005/Atom";
            Write4_Content(@"content", namespace9, ((global::RedditRss.Models.Content)o.@Content), false, false, namespace9, @"http://www.w3.org/2005/Atom");
            string namespace10 = ( parentCompileTimeNs == @"http://www.w3.org/2005/Atom" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2005/Atom";
            WriteElementString(@"id", namespace10, ((global::System.String)o.@Id));
            string namespace11 = ( parentCompileTimeNs == @"http://www.w3.org/2005/Atom" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2005/Atom";
            Write5_Link(@"link", namespace11, ((global::RedditRss.Models.Link)o.@Link), false, false, namespace11, @"http://www.w3.org/2005/Atom");
            string namespace12 = ( parentCompileTimeNs == @"http://www.w3.org/2005/Atom" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2005/Atom";
            WriteElementString(@"updated", namespace12, ((global::System.String)o.@Updated));
            string namespace13 = ( parentCompileTimeNs == @"http://www.w3.org/2005/Atom" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2005/Atom";
            WriteElementString(@"title", namespace13, ((global::System.String)o.@Title));
            WriteEndElement(o);
        }

        void Write7_Feed(string n, string ns, global::RedditRss.Models.Feed o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::RedditRss.Models.Feed)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Feed", defaultNamespace);
            string namespace14 = ( parentCompileTimeNs == @"http://www.w3.org/2005/Atom" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2005/Atom";
            WriteElementString(@"title", namespace14, ((global::System.String)o.@Title));
            {
                global::System.Collections.Generic.List<global::RedditRss.Models.Entry> a = (global::System.Collections.Generic.List<global::RedditRss.Models.Entry>)o.@Entries;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace15 = ( parentCompileTimeNs == @"http://www.w3.org/2005/Atom" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2005/Atom";
                        Write6_Entry(@"entry", namespace15, ((global::RedditRss.Models.Entry)a[ia]), false, false, namespace15, @"http://www.w3.org/2005/Atom");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write69_XmlSchema(string n, string ns, global::System.Xml.Schema.XmlSchema o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchema)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchema", defaultNamespace);
            if (((global::System.Xml.Schema.XmlSchemaForm)o.@AttributeFormDefault) != global::System.Xml.Schema.XmlSchemaForm.@None) {
                WriteAttribute(@"attributeFormDefault", @"", Write9_XmlSchemaForm(((global::System.Xml.Schema.XmlSchemaForm)o.@AttributeFormDefault)));
            }
            if (((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@BlockDefault) != (global::System.Xml.Schema.XmlSchemaDerivationMethod.@None)) {
                WriteAttribute(@"blockDefault", @"", Write10_XmlSchemaDerivationMethod(((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@BlockDefault)));
            }
            if (((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@FinalDefault) != (global::System.Xml.Schema.XmlSchemaDerivationMethod.@None)) {
                WriteAttribute(@"finalDefault", @"", Write10_XmlSchemaDerivationMethod(((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@FinalDefault)));
            }
            if (((global::System.Xml.Schema.XmlSchemaForm)o.@ElementFormDefault) != global::System.Xml.Schema.XmlSchemaForm.@None) {
                WriteAttribute(@"elementFormDefault", @"", Write9_XmlSchemaForm(((global::System.Xml.Schema.XmlSchemaForm)o.@ElementFormDefault)));
            }
            WriteAttribute(@"targetNamespace", @"", ((global::System.String)o.@TargetNamespace));
            WriteAttribute(@"version", @"", ((global::System.String)o.@Version));
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Includes;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaRedefine) {
                                string namespace16 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write67_XmlSchemaRedefine(@"redefine", namespace16, ((global::System.Xml.Schema.XmlSchemaRedefine)ai), false, false, namespace16, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaImport) {
                                string namespace17 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write16_XmlSchemaImport(@"import", namespace17, ((global::System.Xml.Schema.XmlSchemaImport)ai), false, false, namespace17, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaInclude) {
                                string namespace18 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write15_XmlSchemaInclude(@"include", namespace18, ((global::System.Xml.Schema.XmlSchemaInclude)ai), false, false, namespace18, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaElement) {
                                string namespace19 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write57_XmlSchemaElement(@"element", namespace19, ((global::System.Xml.Schema.XmlSchemaElement)ai), false, false, namespace19, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaSimpleType) {
                                string namespace20 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write37_XmlSchemaSimpleType(@"simpleType", namespace20, ((global::System.Xml.Schema.XmlSchemaSimpleType)ai), false, false, namespace20, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaComplexType) {
                                string namespace21 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write65_XmlSchemaComplexType(@"complexType", namespace21, ((global::System.Xml.Schema.XmlSchemaComplexType)ai), false, false, namespace21, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaGroup) {
                                string namespace22 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write66_XmlSchemaGroup(@"group", namespace22, ((global::System.Xml.Schema.XmlSchemaGroup)ai), false, false, namespace22, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaAttribute) {
                                string namespace23 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write39_XmlSchemaAttribute(@"attribute", namespace23, ((global::System.Xml.Schema.XmlSchemaAttribute)ai), false, false, namespace23, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaAttributeGroup) {
                                string namespace24 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write43_XmlSchemaAttributeGroup(@"attributeGroup", namespace24, ((global::System.Xml.Schema.XmlSchemaAttributeGroup)ai), false, false, namespace24, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaNotation) {
                                string namespace25 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write68_XmlSchemaNotation(@"notation", namespace25, ((global::System.Xml.Schema.XmlSchemaNotation)ai), false, false, namespace25, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaAnnotation) {
                                string namespace26 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write14_XmlSchemaAnnotation(@"annotation", namespace26, ((global::System.Xml.Schema.XmlSchemaAnnotation)ai), false, false, namespace26, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write14_XmlSchemaAnnotation(string n, string ns, global::System.Xml.Schema.XmlSchemaAnnotation o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaAnnotation)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaAnnotation", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaAppInfo) {
                                string namespace27 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write13_XmlSchemaAppInfo(@"appinfo", namespace27, ((global::System.Xml.Schema.XmlSchemaAppInfo)ai), false, false, namespace27, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaDocumentation) {
                                string namespace28 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write12_XmlSchemaDocumentation(@"documentation", namespace28, ((global::System.Xml.Schema.XmlSchemaDocumentation)ai), false, false, namespace28, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write12_XmlSchemaDocumentation(string n, string ns, global::System.Xml.Schema.XmlSchemaDocumentation o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaDocumentation)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaDocumentation", defaultNamespace);
            WriteAttribute(@"source", @"", ((global::System.String)o.@Source));
            WriteAttribute(@"lang", @"http://www.w3.org/XML/1998/namespace", ((global::System.String)o.@Language));
            {
                global::System.Xml.XmlNode[] a = (global::System.Xml.XmlNode[])o.@Markup;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        global::System.Xml.XmlNode ai = (global::System.Xml.XmlNode)a[ia];
                        if ((object)(ai) != null){
                            if (ai is System.Xml.XmlElement) {
                                System.Xml.XmlElement elem = (System.Xml.XmlElement)ai;
                                string namespace29 = ( parentCompileTimeNs == null && parentRuntimeNs != null ) ? parentRuntimeNs : null;
                                if ((elem) is System.Xml.XmlNode || elem == null) {
                                    WriteElementLiteral((System.Xml.XmlNode)elem, @"", namespace29, false, true);
                                }
                                else {
                                    throw CreateInvalidAnyTypeException(elem);
                                }
                            }
                            else if (ai is global::System.Xml.XmlNode) {
                                ((global::System.Xml.XmlNode)ai).WriteTo(Writer);
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write13_XmlSchemaAppInfo(string n, string ns, global::System.Xml.Schema.XmlSchemaAppInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaAppInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaAppInfo", defaultNamespace);
            WriteAttribute(@"source", @"", ((global::System.String)o.@Source));
            {
                global::System.Xml.XmlNode[] a = (global::System.Xml.XmlNode[])o.@Markup;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        global::System.Xml.XmlNode ai = (global::System.Xml.XmlNode)a[ia];
                        if ((object)(ai) != null){
                            if (ai is System.Xml.XmlElement) {
                                System.Xml.XmlElement elem = (System.Xml.XmlElement)ai;
                                string namespace30 = ( parentCompileTimeNs == null && parentRuntimeNs != null ) ? parentRuntimeNs : null;
                                if ((elem) is System.Xml.XmlNode || elem == null) {
                                    WriteElementLiteral((System.Xml.XmlNode)elem, @"", namespace30, false, true);
                                }
                                else {
                                    throw CreateInvalidAnyTypeException(elem);
                                }
                            }
                            else if (ai is global::System.Xml.XmlNode) {
                                ((global::System.Xml.XmlNode)ai).WriteTo(Writer);
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write68_XmlSchemaNotation(string n, string ns, global::System.Xml.Schema.XmlSchemaNotation o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaNotation)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaNotation", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            WriteAttribute(@"public", @"", ((global::System.String)o.@Public));
            WriteAttribute(@"system", @"", ((global::System.String)o.@System));
            string namespace31 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace31, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace31, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write43_XmlSchemaAttributeGroup(string n, string ns, global::System.Xml.Schema.XmlSchemaAttributeGroup o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaAttributeGroup)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaAttributeGroup", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            string namespace32 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace32, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace32, @"http://www.w3.org/2001/XMLSchema");
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Attributes;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaAttributeGroupRef) {
                                string namespace33 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write40_XmlSchemaAttributeGroupRef(@"attributeGroup", namespace33, ((global::System.Xml.Schema.XmlSchemaAttributeGroupRef)ai), false, false, namespace33, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaAttribute) {
                                string namespace34 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write39_XmlSchemaAttribute(@"attribute", namespace34, ((global::System.Xml.Schema.XmlSchemaAttribute)ai), false, false, namespace34, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            string namespace35 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write42_XmlSchemaAnyAttribute(@"anyAttribute", namespace35, ((global::System.Xml.Schema.XmlSchemaAnyAttribute)o.@AnyAttribute), false, false, namespace35, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write42_XmlSchemaAnyAttribute(string n, string ns, global::System.Xml.Schema.XmlSchemaAnyAttribute o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaAnyAttribute)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaAnyAttribute", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"namespace", @"", ((global::System.String)o.@Namespace));
            if (((global::System.Xml.Schema.XmlSchemaContentProcessing)o.@ProcessContents) != global::System.Xml.Schema.XmlSchemaContentProcessing.@None) {
                WriteAttribute(@"processContents", @"", Write41_XmlSchemaContentProcessing(((global::System.Xml.Schema.XmlSchemaContentProcessing)o.@ProcessContents)));
            }
            string namespace36 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace36, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace36, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write39_XmlSchemaAttribute(string n, string ns, global::System.Xml.Schema.XmlSchemaAttribute o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaAttribute)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaAttribute", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"default", @"", ((global::System.String)o.@DefaultValue));
            WriteAttribute(@"fixed", @"", ((global::System.String)o.@FixedValue));
            if (((global::System.Xml.Schema.XmlSchemaForm)o.@Form) != global::System.Xml.Schema.XmlSchemaForm.@None) {
                WriteAttribute(@"form", @"", Write9_XmlSchemaForm(((global::System.Xml.Schema.XmlSchemaForm)o.@Form)));
            }
            WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            WriteAttribute(@"ref", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@RefName)));
            WriteAttribute(@"type", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@SchemaTypeName)));
            if (((global::System.Xml.Schema.XmlSchemaUse)o.@Use) != global::System.Xml.Schema.XmlSchemaUse.@None) {
                WriteAttribute(@"use", @"", Write38_XmlSchemaUse(((global::System.Xml.Schema.XmlSchemaUse)o.@Use)));
            }
            string namespace37 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace37, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace37, @"http://www.w3.org/2001/XMLSchema");
            string namespace38 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write37_XmlSchemaSimpleType(@"simpleType", namespace38, ((global::System.Xml.Schema.XmlSchemaSimpleType)o.@SchemaType), false, false, namespace38, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write37_XmlSchemaSimpleType(string n, string ns, global::System.Xml.Schema.XmlSchemaSimpleType o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaSimpleType", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            if (((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@Final) != (global::System.Xml.Schema.XmlSchemaDerivationMethod.@None)) {
                WriteAttribute(@"final", @"", Write10_XmlSchemaDerivationMethod(((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@Final)));
            }
            string namespace39 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace39, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace39, @"http://www.w3.org/2001/XMLSchema");
            if ((object)(o.@Content) != null){
                if (o.@Content is global::System.Xml.Schema.XmlSchemaSimpleTypeUnion) {
                    string namespace40 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write36_XmlSchemaSimpleTypeUnion(@"union", namespace40, ((global::System.Xml.Schema.XmlSchemaSimpleTypeUnion)o.@Content), false, false, namespace40, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Content is global::System.Xml.Schema.XmlSchemaSimpleTypeList) {
                    string namespace41 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write35_XmlSchemaSimpleTypeList(@"list", namespace41, ((global::System.Xml.Schema.XmlSchemaSimpleTypeList)o.@Content), false, false, namespace41, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Content is global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction) {
                    string namespace42 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write34_XmlSchemaSimpleTypeRestriction(@"restriction", namespace42, ((global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction)o.@Content), false, false, namespace42, @"http://www.w3.org/2001/XMLSchema");
                }
                else  if ((object)(o.@Content) != null){
                    throw CreateUnknownTypeException(o.@Content);
                }
            }
            WriteEndElement(o);
        }

        void Write34_XmlSchemaSimpleTypeRestriction(string n, string ns, global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaSimpleTypeRestriction", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"base", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@BaseTypeName)));
            string namespace43 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace43, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace43, @"http://www.w3.org/2001/XMLSchema");
            string namespace44 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write37_XmlSchemaSimpleType(@"simpleType", namespace44, ((global::System.Xml.Schema.XmlSchemaSimpleType)o.@BaseType), false, false, namespace44, @"http://www.w3.org/2001/XMLSchema");
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Facets;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaFractionDigitsFacet) {
                                string namespace45 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write32_XmlSchemaFractionDigitsFacet(@"fractionDigits", namespace45, ((global::System.Xml.Schema.XmlSchemaFractionDigitsFacet)ai), false, false, namespace45, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaTotalDigitsFacet) {
                                string namespace46 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write31_XmlSchemaTotalDigitsFacet(@"totalDigits", namespace46, ((global::System.Xml.Schema.XmlSchemaTotalDigitsFacet)ai), false, false, namespace46, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaMaxLengthFacet) {
                                string namespace47 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write24_XmlSchemaMaxLengthFacet(@"maxLength", namespace47, ((global::System.Xml.Schema.XmlSchemaMaxLengthFacet)ai), false, false, namespace47, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaLengthFacet) {
                                string namespace48 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write22_XmlSchemaLengthFacet(@"length", namespace48, ((global::System.Xml.Schema.XmlSchemaLengthFacet)ai), false, false, namespace48, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaMinLengthFacet) {
                                string namespace49 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write23_XmlSchemaMinLengthFacet(@"minLength", namespace49, ((global::System.Xml.Schema.XmlSchemaMinLengthFacet)ai), false, false, namespace49, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaMinExclusiveFacet) {
                                string namespace50 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write30_XmlSchemaMinExclusiveFacet(@"minExclusive", namespace50, ((global::System.Xml.Schema.XmlSchemaMinExclusiveFacet)ai), false, false, namespace50, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet) {
                                string namespace51 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write33_XmlSchemaWhiteSpaceFacet(@"whiteSpace", namespace51, ((global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet)ai), false, false, namespace51, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaMinInclusiveFacet) {
                                string namespace52 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write29_XmlSchemaMinInclusiveFacet(@"minInclusive", namespace52, ((global::System.Xml.Schema.XmlSchemaMinInclusiveFacet)ai), false, false, namespace52, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaEnumerationFacet) {
                                string namespace53 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write26_XmlSchemaEnumerationFacet(@"enumeration", namespace53, ((global::System.Xml.Schema.XmlSchemaEnumerationFacet)ai), false, false, namespace53, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaPatternFacet) {
                                string namespace54 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write25_XmlSchemaPatternFacet(@"pattern", namespace54, ((global::System.Xml.Schema.XmlSchemaPatternFacet)ai), false, false, namespace54, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet) {
                                string namespace55 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write28_XmlSchemaMaxExclusiveFacet(@"maxExclusive", namespace55, ((global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet)ai), false, false, namespace55, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet) {
                                string namespace56 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write27_XmlSchemaMaxInclusiveFacet(@"maxInclusive", namespace56, ((global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet)ai), false, false, namespace56, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write27_XmlSchemaMaxInclusiveFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaMaxInclusiveFacet", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"value", @"", ((global::System.String)o.@Value));
            if (((global::System.Boolean)o.@IsFixed) != false) {
                WriteAttribute(@"fixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsFixed)));
            }
            string namespace57 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace57, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace57, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write28_XmlSchemaMaxExclusiveFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaMaxExclusiveFacet", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"value", @"", ((global::System.String)o.@Value));
            if (((global::System.Boolean)o.@IsFixed) != false) {
                WriteAttribute(@"fixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsFixed)));
            }
            string namespace58 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace58, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace58, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write25_XmlSchemaPatternFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaPatternFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaPatternFacet)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaPatternFacet", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"value", @"", ((global::System.String)o.@Value));
            if (((global::System.Boolean)o.@IsFixed) != false) {
                WriteAttribute(@"fixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsFixed)));
            }
            string namespace59 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace59, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace59, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write26_XmlSchemaEnumerationFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaEnumerationFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaEnumerationFacet)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaEnumerationFacet", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"value", @"", ((global::System.String)o.@Value));
            if (((global::System.Boolean)o.@IsFixed) != false) {
                WriteAttribute(@"fixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsFixed)));
            }
            string namespace60 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace60, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace60, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write29_XmlSchemaMinInclusiveFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaMinInclusiveFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaMinInclusiveFacet)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaMinInclusiveFacet", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"value", @"", ((global::System.String)o.@Value));
            if (((global::System.Boolean)o.@IsFixed) != false) {
                WriteAttribute(@"fixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsFixed)));
            }
            string namespace61 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace61, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace61, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write33_XmlSchemaWhiteSpaceFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaWhiteSpaceFacet", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"value", @"", ((global::System.String)o.@Value));
            if (((global::System.Boolean)o.@IsFixed) != false) {
                WriteAttribute(@"fixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsFixed)));
            }
            string namespace62 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace62, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace62, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write30_XmlSchemaMinExclusiveFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaMinExclusiveFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaMinExclusiveFacet)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaMinExclusiveFacet", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"value", @"", ((global::System.String)o.@Value));
            if (((global::System.Boolean)o.@IsFixed) != false) {
                WriteAttribute(@"fixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsFixed)));
            }
            string namespace63 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace63, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace63, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write23_XmlSchemaMinLengthFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaMinLengthFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaMinLengthFacet)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaMinLengthFacet", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"value", @"", ((global::System.String)o.@Value));
            if (((global::System.Boolean)o.@IsFixed) != false) {
                WriteAttribute(@"fixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsFixed)));
            }
            string namespace64 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace64, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace64, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write22_XmlSchemaLengthFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaLengthFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaLengthFacet)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaLengthFacet", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"value", @"", ((global::System.String)o.@Value));
            if (((global::System.Boolean)o.@IsFixed) != false) {
                WriteAttribute(@"fixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsFixed)));
            }
            string namespace65 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace65, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace65, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write24_XmlSchemaMaxLengthFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaMaxLengthFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxLengthFacet)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaMaxLengthFacet", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"value", @"", ((global::System.String)o.@Value));
            if (((global::System.Boolean)o.@IsFixed) != false) {
                WriteAttribute(@"fixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsFixed)));
            }
            string namespace66 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace66, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace66, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write31_XmlSchemaTotalDigitsFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaTotalDigitsFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaTotalDigitsFacet)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaTotalDigitsFacet", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"value", @"", ((global::System.String)o.@Value));
            if (((global::System.Boolean)o.@IsFixed) != false) {
                WriteAttribute(@"fixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsFixed)));
            }
            string namespace67 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace67, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace67, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write32_XmlSchemaFractionDigitsFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaFractionDigitsFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaFractionDigitsFacet)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaFractionDigitsFacet", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"value", @"", ((global::System.String)o.@Value));
            if (((global::System.Boolean)o.@IsFixed) != false) {
                WriteAttribute(@"fixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsFixed)));
            }
            string namespace68 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace68, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace68, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write35_XmlSchemaSimpleTypeList(string n, string ns, global::System.Xml.Schema.XmlSchemaSimpleTypeList o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeList)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaSimpleTypeList", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"itemType", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@ItemTypeName)));
            string namespace69 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace69, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace69, @"http://www.w3.org/2001/XMLSchema");
            string namespace70 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write37_XmlSchemaSimpleType(@"simpleType", namespace70, ((global::System.Xml.Schema.XmlSchemaSimpleType)o.@ItemType), false, false, namespace70, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write36_XmlSchemaSimpleTypeUnion(string n, string ns, global::System.Xml.Schema.XmlSchemaSimpleTypeUnion o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeUnion)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaSimpleTypeUnion", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.Xml.XmlQualifiedName[] a = (global::System.Xml.XmlQualifiedName[])o.@MemberTypes;
                if (a != null) {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlQualifiedName ai = (global::System.Xml.XmlQualifiedName)a[i];
                        if (i != 0) sb.Append(" ");
                        sb.Append(FromXmlQualifiedName(ai));
                    }
                    if (sb.Length != 0) {
                        WriteAttribute(@"memberTypes", @"", sb.ToString());
                    }
                }
            }
            string namespace71 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace71, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace71, @"http://www.w3.org/2001/XMLSchema");
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@BaseTypes;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace72 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                        Write37_XmlSchemaSimpleType(@"simpleType", namespace72, ((global::System.Xml.Schema.XmlSchemaSimpleType)a[ia]), false, false, namespace72, @"http://www.w3.org/2001/XMLSchema");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write40_XmlSchemaAttributeGroupRef(string n, string ns, global::System.Xml.Schema.XmlSchemaAttributeGroupRef o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaAttributeGroupRef)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaAttributeGroupRef", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"ref", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@RefName)));
            string namespace73 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace73, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace73, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write66_XmlSchemaGroup(string n, string ns, global::System.Xml.Schema.XmlSchemaGroup o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaGroup)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaGroup", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            string namespace74 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace74, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace74, @"http://www.w3.org/2001/XMLSchema");
            if ((object)(o.@Particle) != null){
                if (o.@Particle is global::System.Xml.Schema.XmlSchemaSequence) {
                    string namespace75 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write59_XmlSchemaSequence(@"sequence", namespace75, ((global::System.Xml.Schema.XmlSchemaSequence)o.@Particle), false, false, namespace75, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Particle is global::System.Xml.Schema.XmlSchemaAll) {
                    string namespace76 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write61_XmlSchemaAll(@"all", namespace76, ((global::System.Xml.Schema.XmlSchemaAll)o.@Particle), false, false, namespace76, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Particle is global::System.Xml.Schema.XmlSchemaChoice) {
                    string namespace77 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write60_XmlSchemaChoice(@"choice", namespace77, ((global::System.Xml.Schema.XmlSchemaChoice)o.@Particle), false, false, namespace77, @"http://www.w3.org/2001/XMLSchema");
                }
                else  if ((object)(o.@Particle) != null){
                    throw CreateUnknownTypeException(o.@Particle);
                }
            }
            WriteEndElement(o);
        }

        void Write60_XmlSchemaChoice(string n, string ns, global::System.Xml.Schema.XmlSchemaChoice o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaChoice)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaChoice", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"minOccurs", @"", ((global::System.String)o.@MinOccursString));
            WriteAttribute(@"maxOccurs", @"", ((global::System.String)o.@MaxOccursString));
            string namespace78 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace78, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace78, @"http://www.w3.org/2001/XMLSchema");
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaSequence) {
                                string namespace79 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write59_XmlSchemaSequence(@"sequence", namespace79, ((global::System.Xml.Schema.XmlSchemaSequence)ai), false, false, namespace79, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaChoice) {
                                string namespace80 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write60_XmlSchemaChoice(@"choice", namespace80, ((global::System.Xml.Schema.XmlSchemaChoice)ai), false, false, namespace80, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaAny) {
                                string namespace81 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write58_XmlSchemaAny(@"any", namespace81, ((global::System.Xml.Schema.XmlSchemaAny)ai), false, false, namespace81, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaGroupRef) {
                                string namespace82 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write50_XmlSchemaGroupRef(@"group", namespace82, ((global::System.Xml.Schema.XmlSchemaGroupRef)ai), false, false, namespace82, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaElement) {
                                string namespace83 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write57_XmlSchemaElement(@"element", namespace83, ((global::System.Xml.Schema.XmlSchemaElement)ai), false, false, namespace83, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write57_XmlSchemaElement(string n, string ns, global::System.Xml.Schema.XmlSchemaElement o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaElement)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaElement", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"minOccurs", @"", ((global::System.String)o.@MinOccursString));
            WriteAttribute(@"maxOccurs", @"", ((global::System.String)o.@MaxOccursString));
            if (((global::System.Boolean)o.@IsAbstract) != false) {
                WriteAttribute(@"abstract", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsAbstract)));
            }
            if (((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@Block) != (global::System.Xml.Schema.XmlSchemaDerivationMethod.@None)) {
                WriteAttribute(@"block", @"", Write10_XmlSchemaDerivationMethod(((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@Block)));
            }
            WriteAttribute(@"default", @"", ((global::System.String)o.@DefaultValue));
            if (((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@Final) != (global::System.Xml.Schema.XmlSchemaDerivationMethod.@None)) {
                WriteAttribute(@"final", @"", Write10_XmlSchemaDerivationMethod(((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@Final)));
            }
            WriteAttribute(@"fixed", @"", ((global::System.String)o.@FixedValue));
            if (((global::System.Xml.Schema.XmlSchemaForm)o.@Form) != global::System.Xml.Schema.XmlSchemaForm.@None) {
                WriteAttribute(@"form", @"", Write9_XmlSchemaForm(((global::System.Xml.Schema.XmlSchemaForm)o.@Form)));
            }
            if ((((global::System.String)o.@Name) != null) && (((global::System.String)o.@Name).Length != 0)) {
                WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            }
            if (((global::System.Boolean)o.@IsNillable) != false) {
                WriteAttribute(@"nillable", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsNillable)));
            }
            WriteAttribute(@"ref", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@RefName)));
            WriteAttribute(@"substitutionGroup", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@SubstitutionGroup)));
            WriteAttribute(@"type", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@SchemaTypeName)));
            string namespace84 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace84, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace84, @"http://www.w3.org/2001/XMLSchema");
            if ((object)(o.@SchemaType) != null){
                if (o.@SchemaType is global::System.Xml.Schema.XmlSchemaSimpleType) {
                    string namespace85 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write37_XmlSchemaSimpleType(@"simpleType", namespace85, ((global::System.Xml.Schema.XmlSchemaSimpleType)o.@SchemaType), false, false, namespace85, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@SchemaType is global::System.Xml.Schema.XmlSchemaComplexType) {
                    string namespace86 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write65_XmlSchemaComplexType(@"complexType", namespace86, ((global::System.Xml.Schema.XmlSchemaComplexType)o.@SchemaType), false, false, namespace86, @"http://www.w3.org/2001/XMLSchema");
                }
                else  if ((object)(o.@SchemaType) != null){
                    throw CreateUnknownTypeException(o.@SchemaType);
                }
            }
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Constraints;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaUnique) {
                                string namespace87 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write56_XmlSchemaUnique(@"unique", namespace87, ((global::System.Xml.Schema.XmlSchemaUnique)ai), false, false, namespace87, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaKeyref) {
                                string namespace88 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write55_XmlSchemaKeyref(@"keyref", namespace88, ((global::System.Xml.Schema.XmlSchemaKeyref)ai), false, false, namespace88, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaKey) {
                                string namespace89 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write54_XmlSchemaKey(@"key", namespace89, ((global::System.Xml.Schema.XmlSchemaKey)ai), false, false, namespace89, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write54_XmlSchemaKey(string n, string ns, global::System.Xml.Schema.XmlSchemaKey o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaKey)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaKey", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            string namespace90 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace90, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace90, @"http://www.w3.org/2001/XMLSchema");
            string namespace91 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write52_XmlSchemaXPath(@"selector", namespace91, ((global::System.Xml.Schema.XmlSchemaXPath)o.@Selector), false, false, namespace91, @"http://www.w3.org/2001/XMLSchema");
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Fields;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace92 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                        Write52_XmlSchemaXPath(@"field", namespace92, ((global::System.Xml.Schema.XmlSchemaXPath)a[ia]), false, false, namespace92, @"http://www.w3.org/2001/XMLSchema");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write52_XmlSchemaXPath(string n, string ns, global::System.Xml.Schema.XmlSchemaXPath o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaXPath)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaXPath", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            if ((((global::System.String)o.@XPath) != null) && (((global::System.String)o.@XPath).Length != 0)) {
                WriteAttribute(@"xpath", @"", ((global::System.String)o.@XPath));
            }
            string namespace93 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace93, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace93, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write55_XmlSchemaKeyref(string n, string ns, global::System.Xml.Schema.XmlSchemaKeyref o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaKeyref)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaKeyref", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            WriteAttribute(@"refer", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@Refer)));
            string namespace94 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace94, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace94, @"http://www.w3.org/2001/XMLSchema");
            string namespace95 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write52_XmlSchemaXPath(@"selector", namespace95, ((global::System.Xml.Schema.XmlSchemaXPath)o.@Selector), false, false, namespace95, @"http://www.w3.org/2001/XMLSchema");
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Fields;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace96 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                        Write52_XmlSchemaXPath(@"field", namespace96, ((global::System.Xml.Schema.XmlSchemaXPath)a[ia]), false, false, namespace96, @"http://www.w3.org/2001/XMLSchema");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write56_XmlSchemaUnique(string n, string ns, global::System.Xml.Schema.XmlSchemaUnique o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaUnique)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaUnique", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            string namespace97 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace97, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace97, @"http://www.w3.org/2001/XMLSchema");
            string namespace98 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write52_XmlSchemaXPath(@"selector", namespace98, ((global::System.Xml.Schema.XmlSchemaXPath)o.@Selector), false, false, namespace98, @"http://www.w3.org/2001/XMLSchema");
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Fields;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace99 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                        Write52_XmlSchemaXPath(@"field", namespace99, ((global::System.Xml.Schema.XmlSchemaXPath)a[ia]), false, false, namespace99, @"http://www.w3.org/2001/XMLSchema");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write65_XmlSchemaComplexType(string n, string ns, global::System.Xml.Schema.XmlSchemaComplexType o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaComplexType", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            if (((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@Final) != (global::System.Xml.Schema.XmlSchemaDerivationMethod.@None)) {
                WriteAttribute(@"final", @"", Write10_XmlSchemaDerivationMethod(((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@Final)));
            }
            if (((global::System.Boolean)o.@IsAbstract) != false) {
                WriteAttribute(@"abstract", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsAbstract)));
            }
            if (((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@Block) != (global::System.Xml.Schema.XmlSchemaDerivationMethod.@None)) {
                WriteAttribute(@"block", @"", Write10_XmlSchemaDerivationMethod(((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@Block)));
            }
            if (((global::System.Boolean)o.@IsMixed) != false) {
                WriteAttribute(@"mixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsMixed)));
            }
            string namespace100 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace100, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace100, @"http://www.w3.org/2001/XMLSchema");
            if ((object)(o.@ContentModel) != null){
                if (o.@ContentModel is global::System.Xml.Schema.XmlSchemaComplexContent) {
                    string namespace101 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write64_XmlSchemaComplexContent(@"complexContent", namespace101, ((global::System.Xml.Schema.XmlSchemaComplexContent)o.@ContentModel), false, false, namespace101, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@ContentModel is global::System.Xml.Schema.XmlSchemaSimpleContent) {
                    string namespace102 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write48_XmlSchemaSimpleContent(@"simpleContent", namespace102, ((global::System.Xml.Schema.XmlSchemaSimpleContent)o.@ContentModel), false, false, namespace102, @"http://www.w3.org/2001/XMLSchema");
                }
                else  if ((object)(o.@ContentModel) != null){
                    throw CreateUnknownTypeException(o.@ContentModel);
                }
            }
            if ((object)(o.@Particle) != null){
                if (o.@Particle is global::System.Xml.Schema.XmlSchemaAll) {
                    string namespace103 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write61_XmlSchemaAll(@"all", namespace103, ((global::System.Xml.Schema.XmlSchemaAll)o.@Particle), false, false, namespace103, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Particle is global::System.Xml.Schema.XmlSchemaSequence) {
                    string namespace104 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write59_XmlSchemaSequence(@"sequence", namespace104, ((global::System.Xml.Schema.XmlSchemaSequence)o.@Particle), false, false, namespace104, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Particle is global::System.Xml.Schema.XmlSchemaChoice) {
                    string namespace105 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write60_XmlSchemaChoice(@"choice", namespace105, ((global::System.Xml.Schema.XmlSchemaChoice)o.@Particle), false, false, namespace105, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Particle is global::System.Xml.Schema.XmlSchemaGroupRef) {
                    string namespace106 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write50_XmlSchemaGroupRef(@"group", namespace106, ((global::System.Xml.Schema.XmlSchemaGroupRef)o.@Particle), false, false, namespace106, @"http://www.w3.org/2001/XMLSchema");
                }
                else  if ((object)(o.@Particle) != null){
                    throw CreateUnknownTypeException(o.@Particle);
                }
            }
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Attributes;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaAttributeGroupRef) {
                                string namespace107 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write40_XmlSchemaAttributeGroupRef(@"attributeGroup", namespace107, ((global::System.Xml.Schema.XmlSchemaAttributeGroupRef)ai), false, false, namespace107, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaAttribute) {
                                string namespace108 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write39_XmlSchemaAttribute(@"attribute", namespace108, ((global::System.Xml.Schema.XmlSchemaAttribute)ai), false, false, namespace108, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            string namespace109 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write42_XmlSchemaAnyAttribute(@"anyAttribute", namespace109, ((global::System.Xml.Schema.XmlSchemaAnyAttribute)o.@AnyAttribute), false, false, namespace109, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write50_XmlSchemaGroupRef(string n, string ns, global::System.Xml.Schema.XmlSchemaGroupRef o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaGroupRef)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaGroupRef", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"minOccurs", @"", ((global::System.String)o.@MinOccursString));
            WriteAttribute(@"maxOccurs", @"", ((global::System.String)o.@MaxOccursString));
            WriteAttribute(@"ref", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@RefName)));
            string namespace110 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace110, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace110, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write59_XmlSchemaSequence(string n, string ns, global::System.Xml.Schema.XmlSchemaSequence o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaSequence)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaSequence", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"minOccurs", @"", ((global::System.String)o.@MinOccursString));
            WriteAttribute(@"maxOccurs", @"", ((global::System.String)o.@MaxOccursString));
            string namespace111 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace111, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace111, @"http://www.w3.org/2001/XMLSchema");
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaSequence) {
                                string namespace112 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write59_XmlSchemaSequence(@"sequence", namespace112, ((global::System.Xml.Schema.XmlSchemaSequence)ai), false, false, namespace112, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaChoice) {
                                string namespace113 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write60_XmlSchemaChoice(@"choice", namespace113, ((global::System.Xml.Schema.XmlSchemaChoice)ai), false, false, namespace113, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaAny) {
                                string namespace114 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write58_XmlSchemaAny(@"any", namespace114, ((global::System.Xml.Schema.XmlSchemaAny)ai), false, false, namespace114, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaGroupRef) {
                                string namespace115 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write50_XmlSchemaGroupRef(@"group", namespace115, ((global::System.Xml.Schema.XmlSchemaGroupRef)ai), false, false, namespace115, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaElement) {
                                string namespace116 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write57_XmlSchemaElement(@"element", namespace116, ((global::System.Xml.Schema.XmlSchemaElement)ai), false, false, namespace116, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write58_XmlSchemaAny(string n, string ns, global::System.Xml.Schema.XmlSchemaAny o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaAny)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaAny", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"minOccurs", @"", ((global::System.String)o.@MinOccursString));
            WriteAttribute(@"maxOccurs", @"", ((global::System.String)o.@MaxOccursString));
            WriteAttribute(@"namespace", @"", ((global::System.String)o.@Namespace));
            if (((global::System.Xml.Schema.XmlSchemaContentProcessing)o.@ProcessContents) != global::System.Xml.Schema.XmlSchemaContentProcessing.@None) {
                WriteAttribute(@"processContents", @"", Write41_XmlSchemaContentProcessing(((global::System.Xml.Schema.XmlSchemaContentProcessing)o.@ProcessContents)));
            }
            string namespace117 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace117, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace117, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write61_XmlSchemaAll(string n, string ns, global::System.Xml.Schema.XmlSchemaAll o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaAll)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaAll", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"minOccurs", @"", ((global::System.String)o.@MinOccursString));
            WriteAttribute(@"maxOccurs", @"", ((global::System.String)o.@MaxOccursString));
            string namespace118 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace118, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace118, @"http://www.w3.org/2001/XMLSchema");
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace119 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                        Write57_XmlSchemaElement(@"element", namespace119, ((global::System.Xml.Schema.XmlSchemaElement)a[ia]), false, false, namespace119, @"http://www.w3.org/2001/XMLSchema");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write48_XmlSchemaSimpleContent(string n, string ns, global::System.Xml.Schema.XmlSchemaSimpleContent o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContent)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaSimpleContent", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            string namespace120 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace120, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace120, @"http://www.w3.org/2001/XMLSchema");
            if ((object)(o.@Content) != null){
                if (o.@Content is global::System.Xml.Schema.XmlSchemaSimpleContentExtension) {
                    string namespace121 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write47_Item(@"extension", namespace121, ((global::System.Xml.Schema.XmlSchemaSimpleContentExtension)o.@Content), false, false, namespace121, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Content is global::System.Xml.Schema.XmlSchemaSimpleContentRestriction) {
                    string namespace122 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write46_Item(@"restriction", namespace122, ((global::System.Xml.Schema.XmlSchemaSimpleContentRestriction)o.@Content), false, false, namespace122, @"http://www.w3.org/2001/XMLSchema");
                }
                else  if ((object)(o.@Content) != null){
                    throw CreateUnknownTypeException(o.@Content);
                }
            }
            WriteEndElement(o);
        }

        void Write46_Item(string n, string ns, global::System.Xml.Schema.XmlSchemaSimpleContentRestriction o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContentRestriction)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaSimpleContentRestriction", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"base", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@BaseTypeName)));
            string namespace123 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace123, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace123, @"http://www.w3.org/2001/XMLSchema");
            string namespace124 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write37_XmlSchemaSimpleType(@"simpleType", namespace124, ((global::System.Xml.Schema.XmlSchemaSimpleType)o.@BaseType), false, false, namespace124, @"http://www.w3.org/2001/XMLSchema");
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Facets;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaFractionDigitsFacet) {
                                string namespace125 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write32_XmlSchemaFractionDigitsFacet(@"fractionDigits", namespace125, ((global::System.Xml.Schema.XmlSchemaFractionDigitsFacet)ai), false, false, namespace125, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaTotalDigitsFacet) {
                                string namespace126 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write31_XmlSchemaTotalDigitsFacet(@"totalDigits", namespace126, ((global::System.Xml.Schema.XmlSchemaTotalDigitsFacet)ai), false, false, namespace126, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaMaxLengthFacet) {
                                string namespace127 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write24_XmlSchemaMaxLengthFacet(@"maxLength", namespace127, ((global::System.Xml.Schema.XmlSchemaMaxLengthFacet)ai), false, false, namespace127, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaLengthFacet) {
                                string namespace128 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write22_XmlSchemaLengthFacet(@"length", namespace128, ((global::System.Xml.Schema.XmlSchemaLengthFacet)ai), false, false, namespace128, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaMinLengthFacet) {
                                string namespace129 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write23_XmlSchemaMinLengthFacet(@"minLength", namespace129, ((global::System.Xml.Schema.XmlSchemaMinLengthFacet)ai), false, false, namespace129, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaMinExclusiveFacet) {
                                string namespace130 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write30_XmlSchemaMinExclusiveFacet(@"minExclusive", namespace130, ((global::System.Xml.Schema.XmlSchemaMinExclusiveFacet)ai), false, false, namespace130, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet) {
                                string namespace131 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write33_XmlSchemaWhiteSpaceFacet(@"whiteSpace", namespace131, ((global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet)ai), false, false, namespace131, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaMinInclusiveFacet) {
                                string namespace132 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write29_XmlSchemaMinInclusiveFacet(@"minInclusive", namespace132, ((global::System.Xml.Schema.XmlSchemaMinInclusiveFacet)ai), false, false, namespace132, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaEnumerationFacet) {
                                string namespace133 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write26_XmlSchemaEnumerationFacet(@"enumeration", namespace133, ((global::System.Xml.Schema.XmlSchemaEnumerationFacet)ai), false, false, namespace133, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaPatternFacet) {
                                string namespace134 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write25_XmlSchemaPatternFacet(@"pattern", namespace134, ((global::System.Xml.Schema.XmlSchemaPatternFacet)ai), false, false, namespace134, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet) {
                                string namespace135 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write28_XmlSchemaMaxExclusiveFacet(@"maxExclusive", namespace135, ((global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet)ai), false, false, namespace135, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet) {
                                string namespace136 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write27_XmlSchemaMaxInclusiveFacet(@"maxInclusive", namespace136, ((global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet)ai), false, false, namespace136, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Attributes;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaAttributeGroupRef) {
                                string namespace137 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write40_XmlSchemaAttributeGroupRef(@"attributeGroup", namespace137, ((global::System.Xml.Schema.XmlSchemaAttributeGroupRef)ai), false, false, namespace137, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaAttribute) {
                                string namespace138 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write39_XmlSchemaAttribute(@"attribute", namespace138, ((global::System.Xml.Schema.XmlSchemaAttribute)ai), false, false, namespace138, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            string namespace139 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write42_XmlSchemaAnyAttribute(@"anyAttribute", namespace139, ((global::System.Xml.Schema.XmlSchemaAnyAttribute)o.@AnyAttribute), false, false, namespace139, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write47_Item(string n, string ns, global::System.Xml.Schema.XmlSchemaSimpleContentExtension o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContentExtension)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaSimpleContentExtension", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"base", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@BaseTypeName)));
            string namespace140 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace140, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace140, @"http://www.w3.org/2001/XMLSchema");
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Attributes;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaAttributeGroupRef) {
                                string namespace141 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write40_XmlSchemaAttributeGroupRef(@"attributeGroup", namespace141, ((global::System.Xml.Schema.XmlSchemaAttributeGroupRef)ai), false, false, namespace141, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaAttribute) {
                                string namespace142 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write39_XmlSchemaAttribute(@"attribute", namespace142, ((global::System.Xml.Schema.XmlSchemaAttribute)ai), false, false, namespace142, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            string namespace143 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write42_XmlSchemaAnyAttribute(@"anyAttribute", namespace143, ((global::System.Xml.Schema.XmlSchemaAnyAttribute)o.@AnyAttribute), false, false, namespace143, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write64_XmlSchemaComplexContent(string n, string ns, global::System.Xml.Schema.XmlSchemaComplexContent o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContent)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaComplexContent", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"mixed", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsMixed)));
            string namespace144 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace144, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace144, @"http://www.w3.org/2001/XMLSchema");
            if ((object)(o.@Content) != null){
                if (o.@Content is global::System.Xml.Schema.XmlSchemaComplexContentExtension) {
                    string namespace145 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write63_Item(@"extension", namespace145, ((global::System.Xml.Schema.XmlSchemaComplexContentExtension)o.@Content), false, false, namespace145, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Content is global::System.Xml.Schema.XmlSchemaComplexContentRestriction) {
                    string namespace146 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write62_Item(@"restriction", namespace146, ((global::System.Xml.Schema.XmlSchemaComplexContentRestriction)o.@Content), false, false, namespace146, @"http://www.w3.org/2001/XMLSchema");
                }
                else  if ((object)(o.@Content) != null){
                    throw CreateUnknownTypeException(o.@Content);
                }
            }
            WriteEndElement(o);
        }

        void Write62_Item(string n, string ns, global::System.Xml.Schema.XmlSchemaComplexContentRestriction o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContentRestriction)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaComplexContentRestriction", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"base", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@BaseTypeName)));
            string namespace147 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace147, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace147, @"http://www.w3.org/2001/XMLSchema");
            if ((object)(o.@Particle) != null){
                if (o.@Particle is global::System.Xml.Schema.XmlSchemaAll) {
                    string namespace148 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write61_XmlSchemaAll(@"all", namespace148, ((global::System.Xml.Schema.XmlSchemaAll)o.@Particle), false, false, namespace148, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Particle is global::System.Xml.Schema.XmlSchemaSequence) {
                    string namespace149 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write59_XmlSchemaSequence(@"sequence", namespace149, ((global::System.Xml.Schema.XmlSchemaSequence)o.@Particle), false, false, namespace149, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Particle is global::System.Xml.Schema.XmlSchemaChoice) {
                    string namespace150 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write60_XmlSchemaChoice(@"choice", namespace150, ((global::System.Xml.Schema.XmlSchemaChoice)o.@Particle), false, false, namespace150, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Particle is global::System.Xml.Schema.XmlSchemaGroupRef) {
                    string namespace151 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write50_XmlSchemaGroupRef(@"group", namespace151, ((global::System.Xml.Schema.XmlSchemaGroupRef)o.@Particle), false, false, namespace151, @"http://www.w3.org/2001/XMLSchema");
                }
                else  if ((object)(o.@Particle) != null){
                    throw CreateUnknownTypeException(o.@Particle);
                }
            }
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Attributes;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaAttributeGroupRef) {
                                string namespace152 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write40_XmlSchemaAttributeGroupRef(@"attributeGroup", namespace152, ((global::System.Xml.Schema.XmlSchemaAttributeGroupRef)ai), false, false, namespace152, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaAttribute) {
                                string namespace153 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write39_XmlSchemaAttribute(@"attribute", namespace153, ((global::System.Xml.Schema.XmlSchemaAttribute)ai), false, false, namespace153, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            string namespace154 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write42_XmlSchemaAnyAttribute(@"anyAttribute", namespace154, ((global::System.Xml.Schema.XmlSchemaAnyAttribute)o.@AnyAttribute), false, false, namespace154, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write63_Item(string n, string ns, global::System.Xml.Schema.XmlSchemaComplexContentExtension o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContentExtension)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaComplexContentExtension", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"base", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@BaseTypeName)));
            string namespace155 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace155, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace155, @"http://www.w3.org/2001/XMLSchema");
            if ((object)(o.@Particle) != null){
                if (o.@Particle is global::System.Xml.Schema.XmlSchemaAll) {
                    string namespace156 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write61_XmlSchemaAll(@"all", namespace156, ((global::System.Xml.Schema.XmlSchemaAll)o.@Particle), false, false, namespace156, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Particle is global::System.Xml.Schema.XmlSchemaSequence) {
                    string namespace157 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write59_XmlSchemaSequence(@"sequence", namespace157, ((global::System.Xml.Schema.XmlSchemaSequence)o.@Particle), false, false, namespace157, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Particle is global::System.Xml.Schema.XmlSchemaChoice) {
                    string namespace158 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write60_XmlSchemaChoice(@"choice", namespace158, ((global::System.Xml.Schema.XmlSchemaChoice)o.@Particle), false, false, namespace158, @"http://www.w3.org/2001/XMLSchema");
                }
                else if (o.@Particle is global::System.Xml.Schema.XmlSchemaGroupRef) {
                    string namespace159 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                    Write50_XmlSchemaGroupRef(@"group", namespace159, ((global::System.Xml.Schema.XmlSchemaGroupRef)o.@Particle), false, false, namespace159, @"http://www.w3.org/2001/XMLSchema");
                }
                else  if ((object)(o.@Particle) != null){
                    throw CreateUnknownTypeException(o.@Particle);
                }
            }
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Attributes;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaAttributeGroupRef) {
                                string namespace160 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write40_XmlSchemaAttributeGroupRef(@"attributeGroup", namespace160, ((global::System.Xml.Schema.XmlSchemaAttributeGroupRef)ai), false, false, namespace160, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaAttribute) {
                                string namespace161 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write39_XmlSchemaAttribute(@"attribute", namespace161, ((global::System.Xml.Schema.XmlSchemaAttribute)ai), false, false, namespace161, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            string namespace162 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write42_XmlSchemaAnyAttribute(@"anyAttribute", namespace162, ((global::System.Xml.Schema.XmlSchemaAnyAttribute)o.@AnyAttribute), false, false, namespace162, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write15_XmlSchemaInclude(string n, string ns, global::System.Xml.Schema.XmlSchemaInclude o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaInclude)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaInclude", defaultNamespace);
            WriteAttribute(@"schemaLocation", @"", ((global::System.String)o.@SchemaLocation));
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            string namespace163 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace163, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace163, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write16_XmlSchemaImport(string n, string ns, global::System.Xml.Schema.XmlSchemaImport o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaImport)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaImport", defaultNamespace);
            WriteAttribute(@"schemaLocation", @"", ((global::System.String)o.@SchemaLocation));
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"namespace", @"", ((global::System.String)o.@Namespace));
            string namespace164 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace164, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace164, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write67_XmlSchemaRedefine(string n, string ns, global::System.Xml.Schema.XmlSchemaRedefine o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaRedefine)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaRedefine", defaultNamespace);
            WriteAttribute(@"schemaLocation", @"", ((global::System.String)o.@SchemaLocation));
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        global::System.Xml.Schema.XmlSchemaObject ai = (global::System.Xml.Schema.XmlSchemaObject)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.Schema.XmlSchemaSimpleType) {
                                string namespace165 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write37_XmlSchemaSimpleType(@"simpleType", namespace165, ((global::System.Xml.Schema.XmlSchemaSimpleType)ai), false, false, namespace165, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaComplexType) {
                                string namespace166 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write65_XmlSchemaComplexType(@"complexType", namespace166, ((global::System.Xml.Schema.XmlSchemaComplexType)ai), false, false, namespace166, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaGroup) {
                                string namespace167 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write66_XmlSchemaGroup(@"group", namespace167, ((global::System.Xml.Schema.XmlSchemaGroup)ai), false, false, namespace167, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaAttributeGroup) {
                                string namespace168 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write43_XmlSchemaAttributeGroup(@"attributeGroup", namespace168, ((global::System.Xml.Schema.XmlSchemaAttributeGroup)ai), false, false, namespace168, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else if (ai is global::System.Xml.Schema.XmlSchemaAnnotation) {
                                string namespace169 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                                Write14_XmlSchemaAnnotation(@"annotation", namespace169, ((global::System.Xml.Schema.XmlSchemaAnnotation)ai), false, false, namespace169, @"http://www.w3.org/2001/XMLSchema");
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write11_XmlSchemaExternal(string n, string ns, global::System.Xml.Schema.XmlSchemaExternal o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaExternal)) {
                }
                else {
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaRedefine)) {
                        Write67_XmlSchemaRedefine(n, ns,(global::System.Xml.Schema.XmlSchemaRedefine)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaImport)) {
                        Write16_XmlSchemaImport(n, ns,(global::System.Xml.Schema.XmlSchemaImport)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaInclude)) {
                        Write15_XmlSchemaInclude(n, ns,(global::System.Xml.Schema.XmlSchemaInclude)o, isNullable, true);
                        return;
                    }
                    throw CreateUnknownTypeException(o);
                }
            }
        }

        void Write18_XmlSchemaType(string n, string ns, global::System.Xml.Schema.XmlSchemaType o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaType)) {
                }
                else {
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexType)) {
                        Write65_XmlSchemaComplexType(n, ns,(global::System.Xml.Schema.XmlSchemaComplexType)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleType)) {
                        Write37_XmlSchemaSimpleType(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleType)o, isNullable, true);
                        return;
                    }
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaType", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            if (((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@Final) != (global::System.Xml.Schema.XmlSchemaDerivationMethod.@None)) {
                WriteAttribute(@"final", @"", Write10_XmlSchemaDerivationMethod(((global::System.Xml.Schema.XmlSchemaDerivationMethod)o.@Final)));
            }
            string namespace170 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace170, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace170, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write19_XmlSchemaSimpleTypeContent(string n, string ns, global::System.Xml.Schema.XmlSchemaSimpleTypeContent o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeContent)) {
                }
                else {
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeUnion)) {
                        Write36_XmlSchemaSimpleTypeUnion(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeUnion)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeList)) {
                        Write35_XmlSchemaSimpleTypeList(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeList)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction)) {
                        Write34_XmlSchemaSimpleTypeRestriction(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction)o, isNullable, true);
                        return;
                    }
                    throw CreateUnknownTypeException(o);
                }
            }
        }

        void Write21_XmlSchemaNumericFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaNumericFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaNumericFacet)) {
                }
                else {
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaFractionDigitsFacet)) {
                        Write32_XmlSchemaFractionDigitsFacet(n, ns,(global::System.Xml.Schema.XmlSchemaFractionDigitsFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaTotalDigitsFacet)) {
                        Write31_XmlSchemaTotalDigitsFacet(n, ns,(global::System.Xml.Schema.XmlSchemaTotalDigitsFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxLengthFacet)) {
                        Write24_XmlSchemaMaxLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMaxLengthFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMinLengthFacet)) {
                        Write23_XmlSchemaMinLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMinLengthFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaLengthFacet)) {
                        Write22_XmlSchemaLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaLengthFacet)o, isNullable, true);
                        return;
                    }
                    throw CreateUnknownTypeException(o);
                }
            }
        }

        void Write20_XmlSchemaFacet(string n, string ns, global::System.Xml.Schema.XmlSchemaFacet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaFacet)) {
                }
                else {
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet)) {
                        Write33_XmlSchemaWhiteSpaceFacet(n, ns,(global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMinExclusiveFacet)) {
                        Write30_XmlSchemaMinExclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMinExclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMinInclusiveFacet)) {
                        Write29_XmlSchemaMinInclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMinInclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet)) {
                        Write28_XmlSchemaMaxExclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet)) {
                        Write27_XmlSchemaMaxInclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaEnumerationFacet)) {
                        Write26_XmlSchemaEnumerationFacet(n, ns,(global::System.Xml.Schema.XmlSchemaEnumerationFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaPatternFacet)) {
                        Write25_XmlSchemaPatternFacet(n, ns,(global::System.Xml.Schema.XmlSchemaPatternFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaNumericFacet)) {
                        Write21_XmlSchemaNumericFacet(n, ns,(global::System.Xml.Schema.XmlSchemaNumericFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaFractionDigitsFacet)) {
                        Write32_XmlSchemaFractionDigitsFacet(n, ns,(global::System.Xml.Schema.XmlSchemaFractionDigitsFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaTotalDigitsFacet)) {
                        Write31_XmlSchemaTotalDigitsFacet(n, ns,(global::System.Xml.Schema.XmlSchemaTotalDigitsFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxLengthFacet)) {
                        Write24_XmlSchemaMaxLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMaxLengthFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMinLengthFacet)) {
                        Write23_XmlSchemaMinLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMinLengthFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaLengthFacet)) {
                        Write22_XmlSchemaLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaLengthFacet)o, isNullable, true);
                        return;
                    }
                    throw CreateUnknownTypeException(o);
                }
            }
        }

        void Write44_XmlSchemaContentModel(string n, string ns, global::System.Xml.Schema.XmlSchemaContentModel o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaContentModel)) {
                }
                else {
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContent)) {
                        Write64_XmlSchemaComplexContent(n, ns,(global::System.Xml.Schema.XmlSchemaComplexContent)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContent)) {
                        Write48_XmlSchemaSimpleContent(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleContent)o, isNullable, true);
                        return;
                    }
                    throw CreateUnknownTypeException(o);
                }
            }
        }

        void Write45_XmlSchemaContent(string n, string ns, global::System.Xml.Schema.XmlSchemaContent o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaContent)) {
                }
                else {
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContentExtension)) {
                        Write63_Item(n, ns,(global::System.Xml.Schema.XmlSchemaComplexContentExtension)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContentRestriction)) {
                        Write62_Item(n, ns,(global::System.Xml.Schema.XmlSchemaComplexContentRestriction)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContentExtension)) {
                        Write47_Item(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleContentExtension)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContentRestriction)) {
                        Write46_Item(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleContentRestriction)o, isNullable, true);
                        return;
                    }
                    throw CreateUnknownTypeException(o);
                }
            }
        }

        void Write51_XmlSchemaGroupBase(string n, string ns, global::System.Xml.Schema.XmlSchemaGroupBase o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaGroupBase)) {
                }
                else {
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAll)) {
                        Write61_XmlSchemaAll(n, ns,(global::System.Xml.Schema.XmlSchemaAll)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSequence)) {
                        Write59_XmlSchemaSequence(n, ns,(global::System.Xml.Schema.XmlSchemaSequence)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaChoice)) {
                        Write60_XmlSchemaChoice(n, ns,(global::System.Xml.Schema.XmlSchemaChoice)o, isNullable, true);
                        return;
                    }
                    throw CreateUnknownTypeException(o);
                }
            }
        }

        void Write49_XmlSchemaParticle(string n, string ns, global::System.Xml.Schema.XmlSchemaParticle o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaParticle)) {
                }
                else {
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAny)) {
                        Write58_XmlSchemaAny(n, ns,(global::System.Xml.Schema.XmlSchemaAny)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaElement)) {
                        Write57_XmlSchemaElement(n, ns,(global::System.Xml.Schema.XmlSchemaElement)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaGroupBase)) {
                        Write51_XmlSchemaGroupBase(n, ns,(global::System.Xml.Schema.XmlSchemaGroupBase)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAll)) {
                        Write61_XmlSchemaAll(n, ns,(global::System.Xml.Schema.XmlSchemaAll)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSequence)) {
                        Write59_XmlSchemaSequence(n, ns,(global::System.Xml.Schema.XmlSchemaSequence)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaChoice)) {
                        Write60_XmlSchemaChoice(n, ns,(global::System.Xml.Schema.XmlSchemaChoice)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaGroupRef)) {
                        Write50_XmlSchemaGroupRef(n, ns,(global::System.Xml.Schema.XmlSchemaGroupRef)o, isNullable, true);
                        return;
                    }
                    throw CreateUnknownTypeException(o);
                }
            }
        }

        void Write53_XmlSchemaIdentityConstraint(string n, string ns, global::System.Xml.Schema.XmlSchemaIdentityConstraint o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaIdentityConstraint)) {
                }
                else {
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaUnique)) {
                        Write56_XmlSchemaUnique(n, ns,(global::System.Xml.Schema.XmlSchemaUnique)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaKeyref)) {
                        Write55_XmlSchemaKeyref(n, ns,(global::System.Xml.Schema.XmlSchemaKeyref)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaKey)) {
                        Write54_XmlSchemaKey(n, ns,(global::System.Xml.Schema.XmlSchemaKey)o, isNullable, true);
                        return;
                    }
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaIdentityConstraint", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            string namespace171 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace171, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace171, @"http://www.w3.org/2001/XMLSchema");
            string namespace172 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write52_XmlSchemaXPath(@"selector", namespace172, ((global::System.Xml.Schema.XmlSchemaXPath)o.@Selector), false, false, namespace172, @"http://www.w3.org/2001/XMLSchema");
            {
                global::System.Xml.Schema.XmlSchemaObjectCollection a = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Fields;
                if (a != null) {
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace173 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
                        Write52_XmlSchemaXPath(@"field", namespace173, ((global::System.Xml.Schema.XmlSchemaXPath)a[ia]), false, false, namespace173, @"http://www.w3.org/2001/XMLSchema");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write17_XmlSchemaAnnotated(string n, string ns, global::System.Xml.Schema.XmlSchemaAnnotated o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaAnnotated)) {
                }
                else {
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaNotation)) {
                        Write68_XmlSchemaNotation(n, ns,(global::System.Xml.Schema.XmlSchemaNotation)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaGroup)) {
                        Write66_XmlSchemaGroup(n, ns,(global::System.Xml.Schema.XmlSchemaGroup)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaXPath)) {
                        Write52_XmlSchemaXPath(n, ns,(global::System.Xml.Schema.XmlSchemaXPath)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaIdentityConstraint)) {
                        Write53_XmlSchemaIdentityConstraint(n, ns,(global::System.Xml.Schema.XmlSchemaIdentityConstraint)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaUnique)) {
                        Write56_XmlSchemaUnique(n, ns,(global::System.Xml.Schema.XmlSchemaUnique)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaKeyref)) {
                        Write55_XmlSchemaKeyref(n, ns,(global::System.Xml.Schema.XmlSchemaKeyref)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaKey)) {
                        Write54_XmlSchemaKey(n, ns,(global::System.Xml.Schema.XmlSchemaKey)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaParticle)) {
                        Write49_XmlSchemaParticle(n, ns,(global::System.Xml.Schema.XmlSchemaParticle)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAny)) {
                        Write58_XmlSchemaAny(n, ns,(global::System.Xml.Schema.XmlSchemaAny)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaElement)) {
                        Write57_XmlSchemaElement(n, ns,(global::System.Xml.Schema.XmlSchemaElement)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaGroupBase)) {
                        Write51_XmlSchemaGroupBase(n, ns,(global::System.Xml.Schema.XmlSchemaGroupBase)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAll)) {
                        Write61_XmlSchemaAll(n, ns,(global::System.Xml.Schema.XmlSchemaAll)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSequence)) {
                        Write59_XmlSchemaSequence(n, ns,(global::System.Xml.Schema.XmlSchemaSequence)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaChoice)) {
                        Write60_XmlSchemaChoice(n, ns,(global::System.Xml.Schema.XmlSchemaChoice)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaGroupRef)) {
                        Write50_XmlSchemaGroupRef(n, ns,(global::System.Xml.Schema.XmlSchemaGroupRef)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaContent)) {
                        Write45_XmlSchemaContent(n, ns,(global::System.Xml.Schema.XmlSchemaContent)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContentExtension)) {
                        Write63_Item(n, ns,(global::System.Xml.Schema.XmlSchemaComplexContentExtension)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContentRestriction)) {
                        Write62_Item(n, ns,(global::System.Xml.Schema.XmlSchemaComplexContentRestriction)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContentExtension)) {
                        Write47_Item(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleContentExtension)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContentRestriction)) {
                        Write46_Item(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleContentRestriction)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaContentModel)) {
                        Write44_XmlSchemaContentModel(n, ns,(global::System.Xml.Schema.XmlSchemaContentModel)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContent)) {
                        Write64_XmlSchemaComplexContent(n, ns,(global::System.Xml.Schema.XmlSchemaComplexContent)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContent)) {
                        Write48_XmlSchemaSimpleContent(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleContent)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAnyAttribute)) {
                        Write42_XmlSchemaAnyAttribute(n, ns,(global::System.Xml.Schema.XmlSchemaAnyAttribute)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAttributeGroupRef)) {
                        Write40_XmlSchemaAttributeGroupRef(n, ns,(global::System.Xml.Schema.XmlSchemaAttributeGroupRef)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaFacet)) {
                        Write20_XmlSchemaFacet(n, ns,(global::System.Xml.Schema.XmlSchemaFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet)) {
                        Write33_XmlSchemaWhiteSpaceFacet(n, ns,(global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMinExclusiveFacet)) {
                        Write30_XmlSchemaMinExclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMinExclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMinInclusiveFacet)) {
                        Write29_XmlSchemaMinInclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMinInclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet)) {
                        Write28_XmlSchemaMaxExclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet)) {
                        Write27_XmlSchemaMaxInclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaEnumerationFacet)) {
                        Write26_XmlSchemaEnumerationFacet(n, ns,(global::System.Xml.Schema.XmlSchemaEnumerationFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaPatternFacet)) {
                        Write25_XmlSchemaPatternFacet(n, ns,(global::System.Xml.Schema.XmlSchemaPatternFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaNumericFacet)) {
                        Write21_XmlSchemaNumericFacet(n, ns,(global::System.Xml.Schema.XmlSchemaNumericFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaFractionDigitsFacet)) {
                        Write32_XmlSchemaFractionDigitsFacet(n, ns,(global::System.Xml.Schema.XmlSchemaFractionDigitsFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaTotalDigitsFacet)) {
                        Write31_XmlSchemaTotalDigitsFacet(n, ns,(global::System.Xml.Schema.XmlSchemaTotalDigitsFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxLengthFacet)) {
                        Write24_XmlSchemaMaxLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMaxLengthFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMinLengthFacet)) {
                        Write23_XmlSchemaMinLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMinLengthFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaLengthFacet)) {
                        Write22_XmlSchemaLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaLengthFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeContent)) {
                        Write19_XmlSchemaSimpleTypeContent(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeContent)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeUnion)) {
                        Write36_XmlSchemaSimpleTypeUnion(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeUnion)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeList)) {
                        Write35_XmlSchemaSimpleTypeList(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeList)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction)) {
                        Write34_XmlSchemaSimpleTypeRestriction(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaType)) {
                        Write18_XmlSchemaType(n, ns,(global::System.Xml.Schema.XmlSchemaType)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexType)) {
                        Write65_XmlSchemaComplexType(n, ns,(global::System.Xml.Schema.XmlSchemaComplexType)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleType)) {
                        Write37_XmlSchemaSimpleType(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleType)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAttribute)) {
                        Write39_XmlSchemaAttribute(n, ns,(global::System.Xml.Schema.XmlSchemaAttribute)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAttributeGroup)) {
                        Write43_XmlSchemaAttributeGroup(n, ns,(global::System.Xml.Schema.XmlSchemaAttributeGroup)o, isNullable, true);
                        return;
                    }
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Namespaces);
            if (needType) WriteXsiType(@"XmlSchemaAnnotated", defaultNamespace);
            WriteAttribute(@"id", @"", ((global::System.String)o.@Id));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@UnhandledAttributes;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            string namespace174 = ( parentCompileTimeNs == @"http://www.w3.org/2001/XMLSchema" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.w3.org/2001/XMLSchema";
            Write14_XmlSchemaAnnotation(@"annotation", namespace174, ((global::System.Xml.Schema.XmlSchemaAnnotation)o.@Annotation), false, false, namespace174, @"http://www.w3.org/2001/XMLSchema");
            WriteEndElement(o);
        }

        void Write8_XmlSchemaObject(string n, string ns, global::System.Xml.Schema.XmlSchemaObject o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Xml.Schema.XmlSchemaObject)) {
                }
                else {
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAnnotated)) {
                        Write17_XmlSchemaAnnotated(n, ns,(global::System.Xml.Schema.XmlSchemaAnnotated)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaNotation)) {
                        Write68_XmlSchemaNotation(n, ns,(global::System.Xml.Schema.XmlSchemaNotation)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaGroup)) {
                        Write66_XmlSchemaGroup(n, ns,(global::System.Xml.Schema.XmlSchemaGroup)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaXPath)) {
                        Write52_XmlSchemaXPath(n, ns,(global::System.Xml.Schema.XmlSchemaXPath)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaIdentityConstraint)) {
                        Write53_XmlSchemaIdentityConstraint(n, ns,(global::System.Xml.Schema.XmlSchemaIdentityConstraint)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaUnique)) {
                        Write56_XmlSchemaUnique(n, ns,(global::System.Xml.Schema.XmlSchemaUnique)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaKeyref)) {
                        Write55_XmlSchemaKeyref(n, ns,(global::System.Xml.Schema.XmlSchemaKeyref)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaKey)) {
                        Write54_XmlSchemaKey(n, ns,(global::System.Xml.Schema.XmlSchemaKey)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaParticle)) {
                        Write49_XmlSchemaParticle(n, ns,(global::System.Xml.Schema.XmlSchemaParticle)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAny)) {
                        Write58_XmlSchemaAny(n, ns,(global::System.Xml.Schema.XmlSchemaAny)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaElement)) {
                        Write57_XmlSchemaElement(n, ns,(global::System.Xml.Schema.XmlSchemaElement)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaGroupBase)) {
                        Write51_XmlSchemaGroupBase(n, ns,(global::System.Xml.Schema.XmlSchemaGroupBase)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAll)) {
                        Write61_XmlSchemaAll(n, ns,(global::System.Xml.Schema.XmlSchemaAll)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSequence)) {
                        Write59_XmlSchemaSequence(n, ns,(global::System.Xml.Schema.XmlSchemaSequence)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaChoice)) {
                        Write60_XmlSchemaChoice(n, ns,(global::System.Xml.Schema.XmlSchemaChoice)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaGroupRef)) {
                        Write50_XmlSchemaGroupRef(n, ns,(global::System.Xml.Schema.XmlSchemaGroupRef)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaContent)) {
                        Write45_XmlSchemaContent(n, ns,(global::System.Xml.Schema.XmlSchemaContent)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContentExtension)) {
                        Write63_Item(n, ns,(global::System.Xml.Schema.XmlSchemaComplexContentExtension)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContentRestriction)) {
                        Write62_Item(n, ns,(global::System.Xml.Schema.XmlSchemaComplexContentRestriction)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContentExtension)) {
                        Write47_Item(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleContentExtension)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContentRestriction)) {
                        Write46_Item(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleContentRestriction)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaContentModel)) {
                        Write44_XmlSchemaContentModel(n, ns,(global::System.Xml.Schema.XmlSchemaContentModel)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexContent)) {
                        Write64_XmlSchemaComplexContent(n, ns,(global::System.Xml.Schema.XmlSchemaComplexContent)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleContent)) {
                        Write48_XmlSchemaSimpleContent(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleContent)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAnyAttribute)) {
                        Write42_XmlSchemaAnyAttribute(n, ns,(global::System.Xml.Schema.XmlSchemaAnyAttribute)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAttributeGroupRef)) {
                        Write40_XmlSchemaAttributeGroupRef(n, ns,(global::System.Xml.Schema.XmlSchemaAttributeGroupRef)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaFacet)) {
                        Write20_XmlSchemaFacet(n, ns,(global::System.Xml.Schema.XmlSchemaFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet)) {
                        Write33_XmlSchemaWhiteSpaceFacet(n, ns,(global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMinExclusiveFacet)) {
                        Write30_XmlSchemaMinExclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMinExclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMinInclusiveFacet)) {
                        Write29_XmlSchemaMinInclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMinInclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet)) {
                        Write28_XmlSchemaMaxExclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet)) {
                        Write27_XmlSchemaMaxInclusiveFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaEnumerationFacet)) {
                        Write26_XmlSchemaEnumerationFacet(n, ns,(global::System.Xml.Schema.XmlSchemaEnumerationFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaPatternFacet)) {
                        Write25_XmlSchemaPatternFacet(n, ns,(global::System.Xml.Schema.XmlSchemaPatternFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaNumericFacet)) {
                        Write21_XmlSchemaNumericFacet(n, ns,(global::System.Xml.Schema.XmlSchemaNumericFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaFractionDigitsFacet)) {
                        Write32_XmlSchemaFractionDigitsFacet(n, ns,(global::System.Xml.Schema.XmlSchemaFractionDigitsFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaTotalDigitsFacet)) {
                        Write31_XmlSchemaTotalDigitsFacet(n, ns,(global::System.Xml.Schema.XmlSchemaTotalDigitsFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMaxLengthFacet)) {
                        Write24_XmlSchemaMaxLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMaxLengthFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaMinLengthFacet)) {
                        Write23_XmlSchemaMinLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaMinLengthFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaLengthFacet)) {
                        Write22_XmlSchemaLengthFacet(n, ns,(global::System.Xml.Schema.XmlSchemaLengthFacet)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeContent)) {
                        Write19_XmlSchemaSimpleTypeContent(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeContent)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeUnion)) {
                        Write36_XmlSchemaSimpleTypeUnion(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeUnion)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeList)) {
                        Write35_XmlSchemaSimpleTypeList(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeList)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction)) {
                        Write34_XmlSchemaSimpleTypeRestriction(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaType)) {
                        Write18_XmlSchemaType(n, ns,(global::System.Xml.Schema.XmlSchemaType)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaComplexType)) {
                        Write65_XmlSchemaComplexType(n, ns,(global::System.Xml.Schema.XmlSchemaComplexType)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaSimpleType)) {
                        Write37_XmlSchemaSimpleType(n, ns,(global::System.Xml.Schema.XmlSchemaSimpleType)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAttribute)) {
                        Write39_XmlSchemaAttribute(n, ns,(global::System.Xml.Schema.XmlSchemaAttribute)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAttributeGroup)) {
                        Write43_XmlSchemaAttributeGroup(n, ns,(global::System.Xml.Schema.XmlSchemaAttributeGroup)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAppInfo)) {
                        Write13_XmlSchemaAppInfo(n, ns,(global::System.Xml.Schema.XmlSchemaAppInfo)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaDocumentation)) {
                        Write12_XmlSchemaDocumentation(n, ns,(global::System.Xml.Schema.XmlSchemaDocumentation)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaAnnotation)) {
                        Write14_XmlSchemaAnnotation(n, ns,(global::System.Xml.Schema.XmlSchemaAnnotation)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaExternal)) {
                        Write11_XmlSchemaExternal(n, ns,(global::System.Xml.Schema.XmlSchemaExternal)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaRedefine)) {
                        Write67_XmlSchemaRedefine(n, ns,(global::System.Xml.Schema.XmlSchemaRedefine)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaImport)) {
                        Write16_XmlSchemaImport(n, ns,(global::System.Xml.Schema.XmlSchemaImport)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchemaInclude)) {
                        Write15_XmlSchemaInclude(n, ns,(global::System.Xml.Schema.XmlSchemaInclude)o, isNullable, true);
                        return;
                    }
                    if (t == typeof(global::System.Xml.Schema.XmlSchema)) {
                        Write69_XmlSchema(n, ns,(global::System.Xml.Schema.XmlSchema)o, isNullable, true);
                        return;
                    }
                    throw CreateUnknownTypeException(o);
                }
            }
        }

        protected override void InitCallbacks() {
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read70_feed(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_feed && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
                    o = Read7_Feed(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":feed");
            }
            return (object)o;
        }

        public object Read71_anyType(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id3_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id4_Item))) {
                    o = Read1_Object(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":anyType");
            }
            return (object)o;
        }

        public object Read72_schema(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id5_schema && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                    o = Read69_XmlSchema(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":schema");
            }
            return (object)o;
        }

        public object Read73_anyType(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id3_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id4_Item))) {
                    o = Read1_Object(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":anyType");
            }
            return (object)o;
        }

        global::System.Object Read1_Object(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
                if (isNull) {
                    if (xsiType != null) return (global::System.Object)ReadTypedNull(xsiType);
                    else return null;
                }
                if (xsiType == null) {
                    return ReadTypedPrimitive(new System.Xml.XmlQualifiedName("anyType", "http://www.w3.org/2001/XMLSchema"));
                }
                else {
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id7_XmlSchemaObject && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read8_XmlSchemaObject(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_XmlSchemaAnnotated && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read17_XmlSchemaAnnotated(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_XmlSchemaNotation && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read68_XmlSchemaNotation(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_XmlSchemaGroup && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read66_XmlSchemaGroup(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_XmlSchemaXPath && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read52_XmlSchemaXPath(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_XmlSchemaIdentityConstraint && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read53_XmlSchemaIdentityConstraint(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_XmlSchemaUnique && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read56_XmlSchemaUnique(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_XmlSchemaKeyref && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read55_XmlSchemaKeyref(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_XmlSchemaKey && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read54_XmlSchemaKey(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_XmlSchemaParticle && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read49_XmlSchemaParticle(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_XmlSchemaAny && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read58_XmlSchemaAny(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_XmlSchemaElement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read57_XmlSchemaElement(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_XmlSchemaGroupBase && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read51_XmlSchemaGroupBase(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_XmlSchemaAll && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read61_XmlSchemaAll(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_XmlSchemaSequence && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read59_XmlSchemaSequence(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_XmlSchemaChoice && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read60_XmlSchemaChoice(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_XmlSchemaGroupRef && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read50_XmlSchemaGroupRef(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id24_XmlSchemaContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read45_XmlSchemaContent(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read63_Item(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id26_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read62_Item(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read47_Item(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id28_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read46_Item(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id29_XmlSchemaContentModel && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read44_XmlSchemaContentModel(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id30_XmlSchemaComplexContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read64_XmlSchemaComplexContent(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id31_XmlSchemaSimpleContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read48_XmlSchemaSimpleContent(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id32_XmlSchemaAnyAttribute && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read42_XmlSchemaAnyAttribute(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id33_XmlSchemaAttributeGroupRef && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read40_XmlSchemaAttributeGroupRef(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id34_XmlSchemaFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read20_XmlSchemaFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id35_XmlSchemaWhiteSpaceFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read33_XmlSchemaWhiteSpaceFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id36_XmlSchemaMinExclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read30_XmlSchemaMinExclusiveFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id37_XmlSchemaMinInclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read29_XmlSchemaMinInclusiveFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id38_XmlSchemaMaxExclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read28_XmlSchemaMaxExclusiveFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id39_XmlSchemaMaxInclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read27_XmlSchemaMaxInclusiveFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id40_XmlSchemaEnumerationFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read26_XmlSchemaEnumerationFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id41_XmlSchemaPatternFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read25_XmlSchemaPatternFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id42_XmlSchemaNumericFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read21_XmlSchemaNumericFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id43_XmlSchemaFractionDigitsFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read32_XmlSchemaFractionDigitsFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id44_XmlSchemaTotalDigitsFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read31_XmlSchemaTotalDigitsFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id45_XmlSchemaMaxLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read24_XmlSchemaMaxLengthFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id46_XmlSchemaMinLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read23_XmlSchemaMinLengthFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id47_XmlSchemaLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read22_XmlSchemaLengthFacet(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id48_XmlSchemaSimpleTypeContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read19_XmlSchemaSimpleTypeContent(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id49_XmlSchemaSimpleTypeUnion && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read36_XmlSchemaSimpleTypeUnion(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id50_XmlSchemaSimpleTypeList && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read35_XmlSchemaSimpleTypeList(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id51_XmlSchemaSimpleTypeRestriction && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read34_XmlSchemaSimpleTypeRestriction(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id52_XmlSchemaType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read18_XmlSchemaType(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id53_XmlSchemaComplexType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read65_XmlSchemaComplexType(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id54_XmlSchemaSimpleType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read37_XmlSchemaSimpleType(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id55_XmlSchemaAttribute && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read39_XmlSchemaAttribute(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id56_XmlSchemaAttributeGroup && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read43_XmlSchemaAttributeGroup(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id57_XmlSchemaAppInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read13_XmlSchemaAppInfo(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id58_XmlSchemaDocumentation && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read12_XmlSchemaDocumentation(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id59_XmlSchemaAnnotation && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read14_XmlSchemaAnnotation(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id60_XmlSchemaExternal && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read11_XmlSchemaExternal(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id61_XmlSchemaRedefine && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read67_XmlSchemaRedefine(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id62_XmlSchemaImport && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read16_XmlSchemaImport(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id63_XmlSchemaInclude && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read15_XmlSchemaInclude(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id64_XmlSchema && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                        return Read69_XmlSchema(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id65_Feed && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwww3org2005Atom)))
                        return Read7_Feed(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id66_Entry && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwww3org2005Atom)))
                        return Read6_Entry(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id67_Link && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwww3org2005Atom)))
                        return Read5_Link(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id68_Content && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwww3org2005Atom)))
                        return Read4_Content(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id69_Category && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwww3org2005Atom)))
                        return Read3_Category(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id70_Author && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwww3org2005Atom)))
                        return Read2_Author(isNullable, false, defaultNamespace);
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id71_XmlSchemaForm && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
                        Reader.ReadStartElement();
                        object e = Read9_XmlSchemaForm(CollapseWhitespace(this.ReadString()));
                        ReadEndElement();
                        return e;
                    }
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id72_XmlSchemaDerivationMethod && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
                        Reader.ReadStartElement();
                        object e = Read10_XmlSchemaDerivationMethod(CollapseWhitespace(this.ReadString()));
                        ReadEndElement();
                        return e;
                    }
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id73_XmlSchemaUse && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
                        Reader.ReadStartElement();
                        object e = Read38_XmlSchemaUse(CollapseWhitespace(this.ReadString()));
                        ReadEndElement();
                        return e;
                    }
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id74_XmlSchemaContentProcessing && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
                        Reader.ReadStartElement();
                        object e = Read41_XmlSchemaContentProcessing(CollapseWhitespace(this.ReadString()));
                        ReadEndElement();
                        return e;
                    }
                    return ReadTypedPrimitive((System.Xml.XmlQualifiedName)xsiType);
                }
            }
            if (isNull) return null;
            global::System.Object o;
            o = new global::System.Object();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations0 = 0;
            int readerCount0 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations0, ref readerCount0);
            }
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaContentProcessing Read41_XmlSchemaContentProcessing(string s) {
            switch (s) {
                case @"skip": return global::System.Xml.Schema.XmlSchemaContentProcessing.@Skip;
                case @"lax": return global::System.Xml.Schema.XmlSchemaContentProcessing.@Lax;
                case @"strict": return global::System.Xml.Schema.XmlSchemaContentProcessing.@Strict;
                default: throw CreateUnknownConstantException(s, typeof(global::System.Xml.Schema.XmlSchemaContentProcessing));
            }
        }

        global::System.Xml.Schema.XmlSchemaUse Read38_XmlSchemaUse(string s) {
            switch (s) {
                case @"optional": return global::System.Xml.Schema.XmlSchemaUse.@Optional;
                case @"prohibited": return global::System.Xml.Schema.XmlSchemaUse.@Prohibited;
                case @"required": return global::System.Xml.Schema.XmlSchemaUse.@Required;
                default: throw CreateUnknownConstantException(s, typeof(global::System.Xml.Schema.XmlSchemaUse));
            }
        }

        System_Runtime_Extensions::System.Collections.Hashtable _XmlSchemaDerivationMethodValues;

        internal System_Runtime_Extensions::System.Collections.Hashtable XmlSchemaDerivationMethodValues {
            get {
                if ((object)_XmlSchemaDerivationMethodValues == null) {
                    System_Runtime_Extensions::System.Collections.Hashtable h = new System_Runtime_Extensions::System.Collections.Hashtable();
                    h.Add(@"", (long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@Empty);
                    h.Add(@"substitution", (long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@Substitution);
                    h.Add(@"extension", (long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@Extension);
                    h.Add(@"restriction", (long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@Restriction);
                    h.Add(@"list", (long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@List);
                    h.Add(@"union", (long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@Union);
                    h.Add(@"#all", (long)global::System.Xml.Schema.XmlSchemaDerivationMethod.@All);
                    _XmlSchemaDerivationMethodValues = h;
                }
                return _XmlSchemaDerivationMethodValues;
            }
        }

        global::System.Xml.Schema.XmlSchemaDerivationMethod Read10_XmlSchemaDerivationMethod(string s) {
            return (global::System.Xml.Schema.XmlSchemaDerivationMethod)ToEnum(s, XmlSchemaDerivationMethodValues, @"global::System.Xml.Schema.XmlSchemaDerivationMethod");
        }

        global::System.Xml.Schema.XmlSchemaForm Read9_XmlSchemaForm(string s) {
            switch (s) {
                case @"qualified": return global::System.Xml.Schema.XmlSchemaForm.@Qualified;
                case @"unqualified": return global::System.Xml.Schema.XmlSchemaForm.@Unqualified;
                default: throw CreateUnknownConstantException(s, typeof(global::System.Xml.Schema.XmlSchemaForm));
            }
        }

        global::RedditRss.Models.Author Read2_Author(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id70_Author && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::RedditRss.Models.Author o;
            o = new global::RedditRss.Models.Author();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations1 = 0;
            int readerCount1 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id75_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
                        {
                            o.@Name = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id76_uri && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
                        {
                            o.@Uri = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2005/Atom:name, http://www.w3.org/2005/Atom:uri");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2005/Atom:name, http://www.w3.org/2005/Atom:uri");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations1, ref readerCount1);
            }
            ReadEndElement();
            return o;
        }

        global::RedditRss.Models.Category Read3_Category(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id69_Category && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::RedditRss.Models.Category o;
            o = new global::RedditRss.Models.Category();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id77_term && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Term = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id78_label && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Label = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":term, :label");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations2 = 0;
            int readerCount2 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations2, ref readerCount2);
            }
            ReadEndElement();
            return o;
        }

        global::RedditRss.Models.Content Read4_Content(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id68_Content && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::RedditRss.Models.Content o;
            o = new global::RedditRss.Models.Content();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id79_type && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Type = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":type");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations3 = 0;
            int readerCount3 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    tmp = ReadString(tmp, false);
                    o.@Text = tmp;
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations3, ref readerCount3);
            }
            ReadEndElement();
            return o;
        }

        global::RedditRss.Models.Link Read5_Link(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id67_Link && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::RedditRss.Models.Link o;
            o = new global::RedditRss.Models.Link();
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id80_rel && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Rel = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id81_href && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Href = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id79_type && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Type = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":rel, :href, :type");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations4 = 0;
            int readerCount4 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations4, ref readerCount4);
            }
            ReadEndElement();
            return o;
        }

        global::RedditRss.Models.Entry Read6_Entry(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id66_Entry && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::RedditRss.Models.Entry o;
            o = new global::RedditRss.Models.Entry();
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations5 = 0;
            int readerCount5 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id82_author && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
                        o.@Author = Read2_Author(false, true, defaultNamespace);
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id83_category && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
                        o.@Category = Read3_Category(false, true, defaultNamespace);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id84_content && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
                        o.@Content = Read4_Content(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
                        {
                            o.@Id = Reader.ReadElementContentAsString();
                        }
                        paramsRead[3] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id86_link && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
                        o.@Link = Read5_Link(false, true, defaultNamespace);
                        paramsRead[4] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id87_updated && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
                        {
                            o.@Updated = Reader.ReadElementContentAsString();
                        }
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id88_title && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
                        {
                            o.@Title = Reader.ReadElementContentAsString();
                        }
                        paramsRead[6] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2005/Atom:author, http://www.w3.org/2005/Atom:category, http://www.w3.org/2005/Atom:content, http://www.w3.org/2005/Atom:id, http://www.w3.org/2005/Atom:link, http://www.w3.org/2005/Atom:updated, http://www.w3.org/2005/Atom:title");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2005/Atom:author, http://www.w3.org/2005/Atom:category, http://www.w3.org/2005/Atom:content, http://www.w3.org/2005/Atom:id, http://www.w3.org/2005/Atom:link, http://www.w3.org/2005/Atom:updated, http://www.w3.org/2005/Atom:title");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations5, ref readerCount5);
            }
            ReadEndElement();
            return o;
        }

        global::RedditRss.Models.Feed Read7_Feed(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id65_Feed && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::RedditRss.Models.Feed o;
            o = new global::RedditRss.Models.Feed();
            if ((object)(o.@Entries) == null) o.@Entries = new global::System.Collections.Generic.List<global::RedditRss.Models.Entry>();
            global::System.Collections.Generic.List<global::RedditRss.Models.Entry> a_1 = (global::System.Collections.Generic.List<global::RedditRss.Models.Entry>)o.@Entries;
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations6 = 0;
            int readerCount6 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id88_title && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
                        {
                            o.@Title = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id89_entry && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwww3org2005Atom))) {
                        if ((object)(a_1) == null) Reader.Skip(); else a_1.Add(Read6_Entry(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2005/Atom:title, http://www.w3.org/2005/Atom:entry");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2005/Atom:title, http://www.w3.org/2005/Atom:entry");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations6, ref readerCount6);
            }
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchema Read69_XmlSchema(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id64_XmlSchema && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchema o;
            o = new global::System.Xml.Schema.XmlSchema();
            global::System.Xml.Schema.XmlSchemaObjectCollection a_7 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Includes;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_8 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Items;
            global::System.Xml.XmlAttribute[] a_10 = null;
            int ca_10 = 0;
            bool[] paramsRead = new bool[11];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id90_attributeFormDefault && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@AttributeFormDefault = Read9_XmlSchemaForm(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id91_blockDefault && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@BlockDefault = Read10_XmlSchemaDerivationMethod(Reader.Value);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id92_finalDefault && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@FinalDefault = Read10_XmlSchemaDerivationMethod(Reader.Value);
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id93_elementFormDefault && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@ElementFormDefault = Read9_XmlSchemaForm(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id94_targetNamespace && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@TargetNamespace = CollapseWhitespace(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id95_version && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Version = CollapseWhitespace(Reader.Value);
                    paramsRead[6] = true;
                }
                else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[9] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_10 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_10, ca_10, typeof(global::System.Xml.XmlAttribute));a_10[ca_10++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_10, ca_10, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_10, ca_10, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations7 = 0;
            int readerCount7 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (((object) Reader.LocalName == (object)id96_include && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_7) == null) Reader.Skip(); else a_7.Add(Read15_XmlSchemaInclude(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id97_import && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_7) == null) Reader.Skip(); else a_7.Add(Read16_XmlSchemaImport(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id98_redefine && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_7) == null) Reader.Skip(); else a_7.Add(Read67_XmlSchemaRedefine(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_8) == null) Reader.Skip(); else a_8.Add(Read14_XmlSchemaAnnotation(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id100_attribute && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_8) == null) Reader.Skip(); else a_8.Add(Read39_XmlSchemaAttribute(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id101_attributeGroup && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_8) == null) Reader.Skip(); else a_8.Add(Read43_XmlSchemaAttributeGroup(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id102_complexType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_8) == null) Reader.Skip(); else a_8.Add(Read65_XmlSchemaComplexType(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id103_simpleType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_8) == null) Reader.Skip(); else a_8.Add(Read37_XmlSchemaSimpleType(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id104_element && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_8) == null) Reader.Skip(); else a_8.Add(Read57_XmlSchemaElement(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id105_group && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_8) == null) Reader.Skip(); else a_8.Add(Read66_XmlSchemaGroup(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id106_notation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_8) == null) Reader.Skip(); else a_8.Add(Read68_XmlSchemaNotation(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:include, http://www.w3.org/2001/XMLSchema:import, http://www.w3.org/2001/XMLSchema:redefine, http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:complexType, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:element, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:notation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:include, http://www.w3.org/2001/XMLSchema:import, http://www.w3.org/2001/XMLSchema:redefine, http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:complexType, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:element, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:notation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations7, ref readerCount7);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_10, ca_10, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaNotation Read68_XmlSchemaNotation(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_XmlSchemaNotation && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaNotation o;
            o = new global::System.Xml.Schema.XmlSchemaNotation();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id75_name && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id107_public && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Public = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id108_system && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@System = Reader.Value;
                    paramsRead[6] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations8 = 0;
            int readerCount8 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations8, ref readerCount8);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaAnnotation Read14_XmlSchemaAnnotation(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id59_XmlSchemaAnnotation && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaAnnotation o;
            o = new global::System.Xml.Schema.XmlSchemaAnnotation();
            global::System.Xml.Schema.XmlSchemaObjectCollection a_2 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Items;
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations9 = 0;
            int readerCount9 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (((object) Reader.LocalName == (object)id109_documentation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_2) == null) Reader.Skip(); else a_2.Add(Read12_XmlSchemaDocumentation(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id110_appinfo && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_2) == null) Reader.Skip(); else a_2.Add(Read13_XmlSchemaAppInfo(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:documentation, http://www.w3.org/2001/XMLSchema:appinfo");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:documentation, http://www.w3.org/2001/XMLSchema:appinfo");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations9, ref readerCount9);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaAppInfo Read13_XmlSchemaAppInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id57_XmlSchemaAppInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaAppInfo o;
            o = new global::System.Xml.Schema.XmlSchemaAppInfo();
            global::System.Xml.XmlNode[] a_2 = null;
            int ca_2 = 0;
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id111_source && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Source = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    UnknownNode((object)o, @":source");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Markup = (global::System.Xml.XmlNode[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlNode), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations10 = 0;
            int readerCount10 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    a_2 = (global::System.Xml.XmlNode[])EnsureArrayIndex(a_2, ca_2, typeof(global::System.Xml.XmlNode));a_2[ca_2++] = (global::System.Xml.XmlNode)ReadXmlNode(false);
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_2 = (global::System.Xml.XmlNode[])EnsureArrayIndex(a_2, ca_2, typeof(global::System.Xml.XmlNode));a_2[ca_2++] = (global::System.Xml.XmlNode)Document.CreateTextNode(this.ReadString());
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations10, ref readerCount10);
            }
            o.@Markup = (global::System.Xml.XmlNode[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlNode), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaDocumentation Read12_XmlSchemaDocumentation(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id58_XmlSchemaDocumentation && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaDocumentation o;
            o = new global::System.Xml.Schema.XmlSchemaDocumentation();
            global::System.Xml.XmlNode[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id111_source && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Source = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id112_lang && string.Equals(Reader.NamespaceURI, id113_Item))) {
                    o.@Language = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    UnknownNode((object)o, @":source, http://www.w3.org/XML/1998/namespace");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Markup = (global::System.Xml.XmlNode[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlNode), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations11 = 0;
            int readerCount11 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    a_3 = (global::System.Xml.XmlNode[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlNode));a_3[ca_3++] = (global::System.Xml.XmlNode)ReadXmlNode(false);
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_3 = (global::System.Xml.XmlNode[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlNode));a_3[ca_3++] = (global::System.Xml.XmlNode)Document.CreateTextNode(this.ReadString());
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations11, ref readerCount11);
            }
            o.@Markup = (global::System.Xml.XmlNode[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlNode), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaGroup Read66_XmlSchemaGroup(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_XmlSchemaGroup && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaGroup o;
            o = new global::System.Xml.Schema.XmlSchemaGroup();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id75_name && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations12 = 0;
            int readerCount12 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id114_choice && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read60_XmlSchemaChoice(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id115_all && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read61_XmlSchemaAll(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id116_sequence && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read59_XmlSchemaSequence(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:sequence");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:sequence");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations12, ref readerCount12);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaSequence Read59_XmlSchemaSequence(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_XmlSchemaSequence && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaSequence o;
            o = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_6 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Items;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id117_minOccurs && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@MinOccursString = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id118_maxOccurs && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@MaxOccursString = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations13 = 0;
            int readerCount13 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id104_element && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read57_XmlSchemaElement(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id105_group && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read50_XmlSchemaGroupRef(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id114_choice && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read60_XmlSchemaChoice(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id116_sequence && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read59_XmlSchemaSequence(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id119_any && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read58_XmlSchemaAny(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:element, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:any");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:element, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:any");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations13, ref readerCount13);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaAny Read58_XmlSchemaAny(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_XmlSchemaAny && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaAny o;
            o = new global::System.Xml.Schema.XmlSchemaAny();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[8];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id117_minOccurs && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@MinOccursString = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id118_maxOccurs && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@MaxOccursString = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id120_namespace && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Namespace = Reader.Value;
                    paramsRead[6] = true;
                }
                else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id121_processContents && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@ProcessContents = Read41_XmlSchemaContentProcessing(Reader.Value);
                    paramsRead[7] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations14 = 0;
            int readerCount14 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations14, ref readerCount14);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaChoice Read60_XmlSchemaChoice(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_XmlSchemaChoice && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaChoice o;
            o = new global::System.Xml.Schema.XmlSchemaChoice();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_6 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Items;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id117_minOccurs && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@MinOccursString = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id118_maxOccurs && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@MaxOccursString = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations15 = 0;
            int readerCount15 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id104_element && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read57_XmlSchemaElement(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id105_group && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read50_XmlSchemaGroupRef(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id114_choice && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read60_XmlSchemaChoice(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id116_sequence && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read59_XmlSchemaSequence(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id119_any && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read58_XmlSchemaAny(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:element, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:any");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:element, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:any");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations15, ref readerCount15);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaGroupRef Read50_XmlSchemaGroupRef(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_XmlSchemaGroupRef && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaGroupRef o;
            o = new global::System.Xml.Schema.XmlSchemaGroupRef();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id117_minOccurs && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@MinOccursString = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id118_maxOccurs && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@MaxOccursString = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id122_ref && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@RefName = ToXmlQualifiedName(Reader.Value);
                    paramsRead[6] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations16 = 0;
            int readerCount16 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations16, ref readerCount16);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaElement Read57_XmlSchemaElement(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_XmlSchemaElement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaElement o;
            o = new global::System.Xml.Schema.XmlSchemaElement();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_18 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Constraints;
            bool[] paramsRead = new bool[19];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id117_minOccurs && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@MinOccursString = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id118_maxOccurs && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@MaxOccursString = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id123_abstract && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsAbstract = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[6] = true;
                }
                else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id124_block && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Block = Read10_XmlSchemaDerivationMethod(Reader.Value);
                    paramsRead[7] = true;
                }
                else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id125_default && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@DefaultValue = Reader.Value;
                    paramsRead[8] = true;
                }
                else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id126_final && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Final = Read10_XmlSchemaDerivationMethod(Reader.Value);
                    paramsRead[9] = true;
                }
                else if (!paramsRead[10] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@FixedValue = Reader.Value;
                    paramsRead[10] = true;
                }
                else if (!paramsRead[11] && ((object) Reader.LocalName == (object)id128_form && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Form = Read9_XmlSchemaForm(Reader.Value);
                    paramsRead[11] = true;
                }
                else if (!paramsRead[12] && ((object) Reader.LocalName == (object)id75_name && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[12] = true;
                }
                else if (!paramsRead[13] && ((object) Reader.LocalName == (object)id129_nillable && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsNillable = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[13] = true;
                }
                else if (!paramsRead[14] && ((object) Reader.LocalName == (object)id122_ref && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@RefName = ToXmlQualifiedName(Reader.Value);
                    paramsRead[14] = true;
                }
                else if (!paramsRead[15] && ((object) Reader.LocalName == (object)id130_substitutionGroup && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@SubstitutionGroup = ToXmlQualifiedName(Reader.Value);
                    paramsRead[15] = true;
                }
                else if (!paramsRead[16] && ((object) Reader.LocalName == (object)id79_type && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@SchemaTypeName = ToXmlQualifiedName(Reader.Value);
                    paramsRead[16] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations17 = 0;
            int readerCount17 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[17] && ((object) Reader.LocalName == (object)id102_complexType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@SchemaType = Read65_XmlSchemaComplexType(false, true, defaultNamespace);
                        paramsRead[17] = true;
                    }
                    else if (!paramsRead[17] && ((object) Reader.LocalName == (object)id103_simpleType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@SchemaType = Read37_XmlSchemaSimpleType(false, true, defaultNamespace);
                        paramsRead[17] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id131_key && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_18) == null) Reader.Skip(); else a_18.Add(Read54_XmlSchemaKey(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id132_keyref && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_18) == null) Reader.Skip(); else a_18.Add(Read55_XmlSchemaKeyref(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id133_unique && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_18) == null) Reader.Skip(); else a_18.Add(Read56_XmlSchemaUnique(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:complexType, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:key, http://www.w3.org/2001/XMLSchema:keyref, http://www.w3.org/2001/XMLSchema:unique");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:complexType, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:key, http://www.w3.org/2001/XMLSchema:keyref, http://www.w3.org/2001/XMLSchema:unique");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations17, ref readerCount17);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaUnique Read56_XmlSchemaUnique(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_XmlSchemaUnique && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaUnique o;
            o = new global::System.Xml.Schema.XmlSchemaUnique();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_6 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Fields;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id75_name && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations18 = 0;
            int readerCount18 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id134_selector && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Selector = Read52_XmlSchemaXPath(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id135_field && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read52_XmlSchemaXPath(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations18, ref readerCount18);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaXPath Read52_XmlSchemaXPath(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_XmlSchemaXPath && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaXPath o;
            o = new global::System.Xml.Schema.XmlSchemaXPath();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id136_xpath && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@XPath = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations19 = 0;
            int readerCount19 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations19, ref readerCount19);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaKeyref Read55_XmlSchemaKeyref(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_XmlSchemaKeyref && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaKeyref o;
            o = new global::System.Xml.Schema.XmlSchemaKeyref();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_6 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Fields;
            bool[] paramsRead = new bool[8];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id75_name && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id137_refer && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Refer = ToXmlQualifiedName(Reader.Value);
                    paramsRead[7] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations20 = 0;
            int readerCount20 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id134_selector && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Selector = Read52_XmlSchemaXPath(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id135_field && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read52_XmlSchemaXPath(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations20, ref readerCount20);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaKey Read54_XmlSchemaKey(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_XmlSchemaKey && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaKey o;
            o = new global::System.Xml.Schema.XmlSchemaKey();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_6 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Fields;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id75_name && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations21 = 0;
            int readerCount21 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id134_selector && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Selector = Read52_XmlSchemaXPath(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id135_field && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read52_XmlSchemaXPath(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations21, ref readerCount21);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaSimpleType Read37_XmlSchemaSimpleType(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id54_XmlSchemaSimpleType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaSimpleType o;
            o = new global::System.Xml.Schema.XmlSchemaSimpleType();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id75_name && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id126_final && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Final = Read10_XmlSchemaDerivationMethod(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations22 = 0;
            int readerCount22 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id138_restriction && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Content = Read34_XmlSchemaSimpleTypeRestriction(false, true, defaultNamespace);
                        paramsRead[6] = true;
                    }
                    else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id139_list && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Content = Read35_XmlSchemaSimpleTypeList(false, true, defaultNamespace);
                        paramsRead[6] = true;
                    }
                    else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id140_union && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Content = Read36_XmlSchemaSimpleTypeUnion(false, true, defaultNamespace);
                        paramsRead[6] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:restriction, http://www.w3.org/2001/XMLSchema:list, http://www.w3.org/2001/XMLSchema:union");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:restriction, http://www.w3.org/2001/XMLSchema:list, http://www.w3.org/2001/XMLSchema:union");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations22, ref readerCount22);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaSimpleTypeUnion Read36_XmlSchemaSimpleTypeUnion(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id49_XmlSchemaSimpleTypeUnion && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaSimpleTypeUnion o;
            o = new global::System.Xml.Schema.XmlSchemaSimpleTypeUnion();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_4 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@BaseTypes;
            global::System.Xml.XmlQualifiedName[] a_5 = null;
            int ca_5 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (((object) Reader.LocalName == (object)id141_memberTypes && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    string listValues = Reader.Value;
                    string[] vals = listValues.Split(null);
                    for (int i = 0; i < vals.Length; i++) {
                        a_5 = (global::System.Xml.XmlQualifiedName[])EnsureArrayIndex(a_5, ca_5, typeof(global::System.Xml.XmlQualifiedName));a_5[ca_5++] = ToXmlQualifiedName(vals[i]);
                    }
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            o.@MemberTypes = (global::System.Xml.XmlQualifiedName[])ShrinkArray(a_5, ca_5, typeof(global::System.Xml.XmlQualifiedName), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                o.@MemberTypes = (global::System.Xml.XmlQualifiedName[])ShrinkArray(a_5, ca_5, typeof(global::System.Xml.XmlQualifiedName), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations23 = 0;
            int readerCount23 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id103_simpleType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_4) == null) Reader.Skip(); else a_4.Add(Read37_XmlSchemaSimpleType(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations23, ref readerCount23);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            o.@MemberTypes = (global::System.Xml.XmlQualifiedName[])ShrinkArray(a_5, ca_5, typeof(global::System.Xml.XmlQualifiedName), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaSimpleTypeList Read35_XmlSchemaSimpleTypeList(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id50_XmlSchemaSimpleTypeList && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaSimpleTypeList o;
            o = new global::System.Xml.Schema.XmlSchemaSimpleTypeList();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id142_itemType && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@ItemTypeName = ToXmlQualifiedName(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations24 = 0;
            int readerCount24 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id103_simpleType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@ItemType = Read37_XmlSchemaSimpleType(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations24, ref readerCount24);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction Read34_XmlSchemaSimpleTypeRestriction(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id51_XmlSchemaSimpleTypeRestriction && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction o;
            o = new global::System.Xml.Schema.XmlSchemaSimpleTypeRestriction();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_6 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Facets;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id143_base && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@BaseTypeName = ToXmlQualifiedName(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations25 = 0;
            int readerCount25 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id103_simpleType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@BaseType = Read37_XmlSchemaSimpleType(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id144_length && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read22_XmlSchemaLengthFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id145_minLength && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read23_XmlSchemaMinLengthFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id146_maxLength && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read24_XmlSchemaMaxLengthFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id147_pattern && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read25_XmlSchemaPatternFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id148_enumeration && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read26_XmlSchemaEnumerationFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id149_maxInclusive && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read27_XmlSchemaMaxInclusiveFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id150_maxExclusive && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read28_XmlSchemaMaxExclusiveFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id151_minInclusive && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read29_XmlSchemaMinInclusiveFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id152_minExclusive && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read30_XmlSchemaMinExclusiveFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id153_totalDigits && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read31_XmlSchemaTotalDigitsFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id154_fractionDigits && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read32_XmlSchemaFractionDigitsFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id155_whiteSpace && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read33_XmlSchemaWhiteSpaceFacet(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:length, http://www.w3.org/2001/XMLSchema:minLength, http://www.w3.org/2001/XMLSchema:maxLength, http://www.w3.org/2001/XMLSchema:pattern, http://www.w3.org/2001/XMLSchema:enumeration, http://www.w3.org/2001/XMLSchema:maxInclusive, http://www.w3.org/2001/XMLSchema:maxExclusive, http://www.w3.org/2001/XMLSchema:minInclusive, http://www.w3.org/2001/XMLSchema:minExclusive, http://www.w3.org/2001/XMLSchema:totalDigits, http://www.w3.org/2001/XMLSchema:fractionDigits, http://www.w3.org/2001/XMLSchema:whiteSpace");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:length, http://www.w3.org/2001/XMLSchema:minLength, http://www.w3.org/2001/XMLSchema:maxLength, http://www.w3.org/2001/XMLSchema:pattern, http://www.w3.org/2001/XMLSchema:enumeration, http://www.w3.org/2001/XMLSchema:maxInclusive, http://www.w3.org/2001/XMLSchema:maxExclusive, http://www.w3.org/2001/XMLSchema:minInclusive, http://www.w3.org/2001/XMLSchema:minExclusive, http://www.w3.org/2001/XMLSchema:totalDigits, http://www.w3.org/2001/XMLSchema:fractionDigits, http://www.w3.org/2001/XMLSchema:whiteSpace");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations25, ref readerCount25);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet Read33_XmlSchemaWhiteSpaceFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id35_XmlSchemaWhiteSpaceFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet o;
            o = new global::System.Xml.Schema.XmlSchemaWhiteSpaceFacet();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id156_value && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsFixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations26 = 0;
            int readerCount26 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations26, ref readerCount26);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaFractionDigitsFacet Read32_XmlSchemaFractionDigitsFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id43_XmlSchemaFractionDigitsFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaFractionDigitsFacet o;
            o = new global::System.Xml.Schema.XmlSchemaFractionDigitsFacet();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id156_value && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsFixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations27 = 0;
            int readerCount27 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations27, ref readerCount27);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaTotalDigitsFacet Read31_XmlSchemaTotalDigitsFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id44_XmlSchemaTotalDigitsFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaTotalDigitsFacet o;
            o = new global::System.Xml.Schema.XmlSchemaTotalDigitsFacet();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id156_value && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsFixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations28 = 0;
            int readerCount28 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations28, ref readerCount28);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaMinExclusiveFacet Read30_XmlSchemaMinExclusiveFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id36_XmlSchemaMinExclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaMinExclusiveFacet o;
            o = new global::System.Xml.Schema.XmlSchemaMinExclusiveFacet();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id156_value && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsFixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations29 = 0;
            int readerCount29 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations29, ref readerCount29);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaMinInclusiveFacet Read29_XmlSchemaMinInclusiveFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id37_XmlSchemaMinInclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaMinInclusiveFacet o;
            o = new global::System.Xml.Schema.XmlSchemaMinInclusiveFacet();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id156_value && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsFixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations30 = 0;
            int readerCount30 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations30, ref readerCount30);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet Read28_XmlSchemaMaxExclusiveFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id38_XmlSchemaMaxExclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet o;
            o = new global::System.Xml.Schema.XmlSchemaMaxExclusiveFacet();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id156_value && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsFixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations31 = 0;
            int readerCount31 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations31, ref readerCount31);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet Read27_XmlSchemaMaxInclusiveFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id39_XmlSchemaMaxInclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet o;
            o = new global::System.Xml.Schema.XmlSchemaMaxInclusiveFacet();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id156_value && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsFixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations32 = 0;
            int readerCount32 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations32, ref readerCount32);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaEnumerationFacet Read26_XmlSchemaEnumerationFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id40_XmlSchemaEnumerationFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaEnumerationFacet o;
            o = new global::System.Xml.Schema.XmlSchemaEnumerationFacet();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id156_value && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsFixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations33 = 0;
            int readerCount33 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations33, ref readerCount33);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaPatternFacet Read25_XmlSchemaPatternFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id41_XmlSchemaPatternFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaPatternFacet o;
            o = new global::System.Xml.Schema.XmlSchemaPatternFacet();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id156_value && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsFixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations34 = 0;
            int readerCount34 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations34, ref readerCount34);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaMaxLengthFacet Read24_XmlSchemaMaxLengthFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id45_XmlSchemaMaxLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaMaxLengthFacet o;
            o = new global::System.Xml.Schema.XmlSchemaMaxLengthFacet();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id156_value && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsFixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations35 = 0;
            int readerCount35 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations35, ref readerCount35);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaMinLengthFacet Read23_XmlSchemaMinLengthFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id46_XmlSchemaMinLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaMinLengthFacet o;
            o = new global::System.Xml.Schema.XmlSchemaMinLengthFacet();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id156_value && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsFixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations36 = 0;
            int readerCount36 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations36, ref readerCount36);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaLengthFacet Read22_XmlSchemaLengthFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id47_XmlSchemaLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaLengthFacet o;
            o = new global::System.Xml.Schema.XmlSchemaLengthFacet();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id156_value && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsFixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations37 = 0;
            int readerCount37 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations37, ref readerCount37);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaComplexType Read65_XmlSchemaComplexType(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id53_XmlSchemaComplexType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaComplexType o;
            o = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_11 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Attributes;
            bool[] paramsRead = new bool[13];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id75_name && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id126_final && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Final = Read10_XmlSchemaDerivationMethod(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id123_abstract && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsAbstract = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[6] = true;
                }
                else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id124_block && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Block = Read10_XmlSchemaDerivationMethod(Reader.Value);
                    paramsRead[7] = true;
                }
                else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id157_mixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsMixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[8] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations38 = 0;
            int readerCount38 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id158_simpleContent && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@ContentModel = Read48_XmlSchemaSimpleContent(false, true, defaultNamespace);
                        paramsRead[9] = true;
                    }
                    else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id159_complexContent && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@ContentModel = Read64_XmlSchemaComplexContent(false, true, defaultNamespace);
                        paramsRead[9] = true;
                    }
                    else if (!paramsRead[10] && ((object) Reader.LocalName == (object)id105_group && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read50_XmlSchemaGroupRef(false, true, defaultNamespace);
                        paramsRead[10] = true;
                    }
                    else if (!paramsRead[10] && ((object) Reader.LocalName == (object)id114_choice && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read60_XmlSchemaChoice(false, true, defaultNamespace);
                        paramsRead[10] = true;
                    }
                    else if (!paramsRead[10] && ((object) Reader.LocalName == (object)id115_all && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read61_XmlSchemaAll(false, true, defaultNamespace);
                        paramsRead[10] = true;
                    }
                    else if (!paramsRead[10] && ((object) Reader.LocalName == (object)id116_sequence && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read59_XmlSchemaSequence(false, true, defaultNamespace);
                        paramsRead[10] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id100_attribute && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_11) == null) Reader.Skip(); else a_11.Add(Read39_XmlSchemaAttribute(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id101_attributeGroup && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_11) == null) Reader.Skip(); else a_11.Add(Read40_XmlSchemaAttributeGroupRef(false, true, defaultNamespace));
                    }
                    else if (!paramsRead[12] && ((object) Reader.LocalName == (object)id160_anyAttribute && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@AnyAttribute = Read42_XmlSchemaAnyAttribute(false, true, defaultNamespace);
                        paramsRead[12] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleContent, http://www.w3.org/2001/XMLSchema:complexContent, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleContent, http://www.w3.org/2001/XMLSchema:complexContent, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations38, ref readerCount38);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaAnyAttribute Read42_XmlSchemaAnyAttribute(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id32_XmlSchemaAnyAttribute && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaAnyAttribute o;
            o = new global::System.Xml.Schema.XmlSchemaAnyAttribute();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id120_namespace && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Namespace = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id121_processContents && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@ProcessContents = Read41_XmlSchemaContentProcessing(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations39 = 0;
            int readerCount39 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations39, ref readerCount39);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaAttributeGroupRef Read40_XmlSchemaAttributeGroupRef(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id33_XmlSchemaAttributeGroupRef && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaAttributeGroupRef o;
            o = new global::System.Xml.Schema.XmlSchemaAttributeGroupRef();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id122_ref && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@RefName = ToXmlQualifiedName(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations40 = 0;
            int readerCount40 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations40, ref readerCount40);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaAttribute Read39_XmlSchemaAttribute(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id55_XmlSchemaAttribute && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaAttribute o;
            o = new global::System.Xml.Schema.XmlSchemaAttribute();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[12];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id125_default && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@DefaultValue = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id127_fixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@FixedValue = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id128_form && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Form = Read9_XmlSchemaForm(Reader.Value);
                    paramsRead[6] = true;
                }
                else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id75_name && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[7] = true;
                }
                else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id122_ref && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@RefName = ToXmlQualifiedName(Reader.Value);
                    paramsRead[8] = true;
                }
                else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id79_type && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@SchemaTypeName = ToXmlQualifiedName(Reader.Value);
                    paramsRead[9] = true;
                }
                else if (!paramsRead[11] && ((object) Reader.LocalName == (object)id161_use && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Use = Read38_XmlSchemaUse(Reader.Value);
                    paramsRead[11] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations41 = 0;
            int readerCount41 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[10] && ((object) Reader.LocalName == (object)id103_simpleType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@SchemaType = Read37_XmlSchemaSimpleType(false, true, defaultNamespace);
                        paramsRead[10] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations41, ref readerCount41);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaAll Read61_XmlSchemaAll(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_XmlSchemaAll && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaAll o;
            o = new global::System.Xml.Schema.XmlSchemaAll();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_6 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Items;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id117_minOccurs && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@MinOccursString = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id118_maxOccurs && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@MaxOccursString = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations42 = 0;
            int readerCount42 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id104_element && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read57_XmlSchemaElement(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:element");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:element");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations42, ref readerCount42);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaComplexContent Read64_XmlSchemaComplexContent(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id30_XmlSchemaComplexContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaComplexContent o;
            o = new global::System.Xml.Schema.XmlSchemaComplexContent();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id157_mixed && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@IsMixed = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations43 = 0;
            int readerCount43 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id138_restriction && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Content = Read62_Item(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id162_extension && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Content = Read63_Item(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:restriction, http://www.w3.org/2001/XMLSchema:extension");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:restriction, http://www.w3.org/2001/XMLSchema:extension");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations43, ref readerCount43);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaComplexContentExtension Read63_Item(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaComplexContentExtension o;
            o = new global::System.Xml.Schema.XmlSchemaComplexContentExtension();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_6 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Attributes;
            bool[] paramsRead = new bool[8];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id143_base && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@BaseTypeName = ToXmlQualifiedName(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations44 = 0;
            int readerCount44 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id105_group && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read50_XmlSchemaGroupRef(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id114_choice && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read60_XmlSchemaChoice(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id115_all && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read61_XmlSchemaAll(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id116_sequence && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read59_XmlSchemaSequence(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id100_attribute && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read39_XmlSchemaAttribute(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id101_attributeGroup && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read40_XmlSchemaAttributeGroupRef(false, true, defaultNamespace));
                    }
                    else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id160_anyAttribute && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@AnyAttribute = Read42_XmlSchemaAnyAttribute(false, true, defaultNamespace);
                        paramsRead[7] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations44, ref readerCount44);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaComplexContentRestriction Read62_Item(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id26_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaComplexContentRestriction o;
            o = new global::System.Xml.Schema.XmlSchemaComplexContentRestriction();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_6 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Attributes;
            bool[] paramsRead = new bool[8];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id143_base && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@BaseTypeName = ToXmlQualifiedName(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations45 = 0;
            int readerCount45 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id105_group && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read50_XmlSchemaGroupRef(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id114_choice && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read60_XmlSchemaChoice(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id115_all && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read61_XmlSchemaAll(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id116_sequence && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Particle = Read59_XmlSchemaSequence(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id100_attribute && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read39_XmlSchemaAttribute(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id101_attributeGroup && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read40_XmlSchemaAttributeGroupRef(false, true, defaultNamespace));
                    }
                    else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id160_anyAttribute && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@AnyAttribute = Read42_XmlSchemaAnyAttribute(false, true, defaultNamespace);
                        paramsRead[7] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations45, ref readerCount45);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaSimpleContent Read48_XmlSchemaSimpleContent(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id31_XmlSchemaSimpleContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaSimpleContent o;
            o = new global::System.Xml.Schema.XmlSchemaSimpleContent();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations46 = 0;
            int readerCount46 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id138_restriction && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Content = Read46_Item(false, true, defaultNamespace);
                        paramsRead[4] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id162_extension && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Content = Read47_Item(false, true, defaultNamespace);
                        paramsRead[4] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:restriction, http://www.w3.org/2001/XMLSchema:extension");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:restriction, http://www.w3.org/2001/XMLSchema:extension");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations46, ref readerCount46);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaSimpleContentExtension Read47_Item(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaSimpleContentExtension o;
            o = new global::System.Xml.Schema.XmlSchemaSimpleContentExtension();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_5 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Attributes;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id143_base && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@BaseTypeName = ToXmlQualifiedName(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations47 = 0;
            int readerCount47 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id100_attribute && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_5) == null) Reader.Skip(); else a_5.Add(Read39_XmlSchemaAttribute(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id101_attributeGroup && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_5) == null) Reader.Skip(); else a_5.Add(Read40_XmlSchemaAttributeGroupRef(false, true, defaultNamespace));
                    }
                    else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id160_anyAttribute && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@AnyAttribute = Read42_XmlSchemaAnyAttribute(false, true, defaultNamespace);
                        paramsRead[6] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations47, ref readerCount47);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaSimpleContentRestriction Read46_Item(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id28_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaSimpleContentRestriction o;
            o = new global::System.Xml.Schema.XmlSchemaSimpleContentRestriction();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_6 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Facets;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_7 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Attributes;
            bool[] paramsRead = new bool[9];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id143_base && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@BaseTypeName = ToXmlQualifiedName(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations48 = 0;
            int readerCount48 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id103_simpleType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@BaseType = Read37_XmlSchemaSimpleType(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id144_length && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read22_XmlSchemaLengthFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id145_minLength && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read23_XmlSchemaMinLengthFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id146_maxLength && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read24_XmlSchemaMaxLengthFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id147_pattern && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read25_XmlSchemaPatternFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id148_enumeration && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read26_XmlSchemaEnumerationFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id149_maxInclusive && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read27_XmlSchemaMaxInclusiveFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id150_maxExclusive && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read28_XmlSchemaMaxExclusiveFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id151_minInclusive && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read29_XmlSchemaMinInclusiveFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id152_minExclusive && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read30_XmlSchemaMinExclusiveFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id153_totalDigits && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read31_XmlSchemaTotalDigitsFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id154_fractionDigits && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read32_XmlSchemaFractionDigitsFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id155_whiteSpace && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read33_XmlSchemaWhiteSpaceFacet(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id100_attribute && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_7) == null) Reader.Skip(); else a_7.Add(Read39_XmlSchemaAttribute(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id101_attributeGroup && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_7) == null) Reader.Skip(); else a_7.Add(Read40_XmlSchemaAttributeGroupRef(false, true, defaultNamespace));
                    }
                    else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id160_anyAttribute && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@AnyAttribute = Read42_XmlSchemaAnyAttribute(false, true, defaultNamespace);
                        paramsRead[8] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:length, http://www.w3.org/2001/XMLSchema:minLength, http://www.w3.org/2001/XMLSchema:maxLength, http://www.w3.org/2001/XMLSchema:pattern, http://www.w3.org/2001/XMLSchema:enumeration, http://www.w3.org/2001/XMLSchema:maxInclusive, http://www.w3.org/2001/XMLSchema:maxExclusive, http://www.w3.org/2001/XMLSchema:minInclusive, http://www.w3.org/2001/XMLSchema:minExclusive, http://www.w3.org/2001/XMLSchema:totalDigits, http://www.w3.org/2001/XMLSchema:fractionDigits, http://www.w3.org/2001/XMLSchema:whiteSpace, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:length, http://www.w3.org/2001/XMLSchema:minLength, http://www.w3.org/2001/XMLSchema:maxLength, http://www.w3.org/2001/XMLSchema:pattern, http://www.w3.org/2001/XMLSchema:enumeration, http://www.w3.org/2001/XMLSchema:maxInclusive, http://www.w3.org/2001/XMLSchema:maxExclusive, http://www.w3.org/2001/XMLSchema:minInclusive, http://www.w3.org/2001/XMLSchema:minExclusive, http://www.w3.org/2001/XMLSchema:totalDigits, http://www.w3.org/2001/XMLSchema:fractionDigits, http://www.w3.org/2001/XMLSchema:whiteSpace, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations48, ref readerCount48);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaAttributeGroup Read43_XmlSchemaAttributeGroup(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id56_XmlSchemaAttributeGroup && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaAttributeGroup o;
            o = new global::System.Xml.Schema.XmlSchemaAttributeGroup();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_5 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Attributes;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id75_name && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations49 = 0;
            int readerCount49 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id100_attribute && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_5) == null) Reader.Skip(); else a_5.Add(Read39_XmlSchemaAttribute(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id101_attributeGroup && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_5) == null) Reader.Skip(); else a_5.Add(Read40_XmlSchemaAttributeGroupRef(false, true, defaultNamespace));
                    }
                    else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id160_anyAttribute && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@AnyAttribute = Read42_XmlSchemaAnyAttribute(false, true, defaultNamespace);
                        paramsRead[6] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations49, ref readerCount49);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaRedefine Read67_XmlSchemaRedefine(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id61_XmlSchemaRedefine && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaRedefine o;
            o = new global::System.Xml.Schema.XmlSchemaRedefine();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_4 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Items;
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id163_schemaLocation && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@SchemaLocation = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[2] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations50 = 0;
            int readerCount50 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_4) == null) Reader.Skip(); else a_4.Add(Read14_XmlSchemaAnnotation(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id101_attributeGroup && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_4) == null) Reader.Skip(); else a_4.Add(Read43_XmlSchemaAttributeGroup(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id102_complexType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_4) == null) Reader.Skip(); else a_4.Add(Read65_XmlSchemaComplexType(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id105_group && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_4) == null) Reader.Skip(); else a_4.Add(Read66_XmlSchemaGroup(false, true, defaultNamespace));
                    }
                    else if (((object) Reader.LocalName == (object)id103_simpleType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_4) == null) Reader.Skip(); else a_4.Add(Read37_XmlSchemaSimpleType(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:complexType, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:simpleType");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:complexType, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:simpleType");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations50, ref readerCount50);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaImport Read16_XmlSchemaImport(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id62_XmlSchemaImport && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaImport o;
            o = new global::System.Xml.Schema.XmlSchemaImport();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id163_schemaLocation && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@SchemaLocation = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id120_namespace && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Namespace = CollapseWhitespace(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations51 = 0;
            int readerCount51 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[5] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations51, ref readerCount51);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaInclude Read15_XmlSchemaInclude(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id63_XmlSchemaInclude && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaInclude o;
            o = new global::System.Xml.Schema.XmlSchemaInclude();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id163_schemaLocation && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@SchemaLocation = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[2] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations52 = 0;
            int readerCount52 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[4] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[4] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations52, ref readerCount52);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaExternal Read11_XmlSchemaExternal(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id60_XmlSchemaExternal && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id61_XmlSchemaRedefine && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read67_XmlSchemaRedefine(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id62_XmlSchemaImport && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read16_XmlSchemaImport(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id63_XmlSchemaInclude && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read15_XmlSchemaInclude(isNullable, false, defaultNamespace);
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            throw CreateAbstractTypeException(@"XmlSchemaExternal", @"http://www.w3.org/2001/XMLSchema");
        }

        global::System.Xml.Schema.XmlSchemaType Read18_XmlSchemaType(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id52_XmlSchemaType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id53_XmlSchemaComplexType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read65_XmlSchemaComplexType(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id54_XmlSchemaSimpleType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read37_XmlSchemaSimpleType(isNullable, false, defaultNamespace);
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaType o;
            o = new global::System.Xml.Schema.XmlSchemaType();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id75_name && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id126_final && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Final = Read10_XmlSchemaDerivationMethod(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations53 = 0;
            int readerCount53 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations53, ref readerCount53);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaSimpleTypeContent Read19_XmlSchemaSimpleTypeContent(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id48_XmlSchemaSimpleTypeContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id49_XmlSchemaSimpleTypeUnion && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read36_XmlSchemaSimpleTypeUnion(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id50_XmlSchemaSimpleTypeList && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read35_XmlSchemaSimpleTypeList(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id51_XmlSchemaSimpleTypeRestriction && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read34_XmlSchemaSimpleTypeRestriction(isNullable, false, defaultNamespace);
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            throw CreateAbstractTypeException(@"XmlSchemaSimpleTypeContent", @"http://www.w3.org/2001/XMLSchema");
        }

        global::System.Xml.Schema.XmlSchemaNumericFacet Read21_XmlSchemaNumericFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id42_XmlSchemaNumericFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id43_XmlSchemaFractionDigitsFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read32_XmlSchemaFractionDigitsFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id44_XmlSchemaTotalDigitsFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read31_XmlSchemaTotalDigitsFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id45_XmlSchemaMaxLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read24_XmlSchemaMaxLengthFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id46_XmlSchemaMinLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read23_XmlSchemaMinLengthFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id47_XmlSchemaLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read22_XmlSchemaLengthFacet(isNullable, false, defaultNamespace);
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            throw CreateAbstractTypeException(@"XmlSchemaNumericFacet", @"http://www.w3.org/2001/XMLSchema");
        }

        global::System.Xml.Schema.XmlSchemaFacet Read20_XmlSchemaFacet(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id34_XmlSchemaFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id35_XmlSchemaWhiteSpaceFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read33_XmlSchemaWhiteSpaceFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id36_XmlSchemaMinExclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read30_XmlSchemaMinExclusiveFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id37_XmlSchemaMinInclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read29_XmlSchemaMinInclusiveFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id38_XmlSchemaMaxExclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read28_XmlSchemaMaxExclusiveFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id39_XmlSchemaMaxInclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read27_XmlSchemaMaxInclusiveFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id40_XmlSchemaEnumerationFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read26_XmlSchemaEnumerationFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id41_XmlSchemaPatternFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read25_XmlSchemaPatternFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id42_XmlSchemaNumericFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read21_XmlSchemaNumericFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id43_XmlSchemaFractionDigitsFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read32_XmlSchemaFractionDigitsFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id44_XmlSchemaTotalDigitsFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read31_XmlSchemaTotalDigitsFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id45_XmlSchemaMaxLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read24_XmlSchemaMaxLengthFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id46_XmlSchemaMinLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read23_XmlSchemaMinLengthFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id47_XmlSchemaLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read22_XmlSchemaLengthFacet(isNullable, false, defaultNamespace);
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            throw CreateAbstractTypeException(@"XmlSchemaFacet", @"http://www.w3.org/2001/XMLSchema");
        }

        global::System.Xml.Schema.XmlSchemaContentModel Read44_XmlSchemaContentModel(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id29_XmlSchemaContentModel && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id30_XmlSchemaComplexContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read64_XmlSchemaComplexContent(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id31_XmlSchemaSimpleContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read48_XmlSchemaSimpleContent(isNullable, false, defaultNamespace);
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            throw CreateAbstractTypeException(@"XmlSchemaContentModel", @"http://www.w3.org/2001/XMLSchema");
        }

        global::System.Xml.Schema.XmlSchemaContent Read45_XmlSchemaContent(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id24_XmlSchemaContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read63_Item(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id26_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read62_Item(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read47_Item(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id28_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read46_Item(isNullable, false, defaultNamespace);
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            throw CreateAbstractTypeException(@"XmlSchemaContent", @"http://www.w3.org/2001/XMLSchema");
        }

        global::System.Xml.Schema.XmlSchemaGroupBase Read51_XmlSchemaGroupBase(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_XmlSchemaGroupBase && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_XmlSchemaAll && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read61_XmlSchemaAll(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_XmlSchemaSequence && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read59_XmlSchemaSequence(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_XmlSchemaChoice && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read60_XmlSchemaChoice(isNullable, false, defaultNamespace);
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            throw CreateAbstractTypeException(@"XmlSchemaGroupBase", @"http://www.w3.org/2001/XMLSchema");
        }

        global::System.Xml.Schema.XmlSchemaParticle Read49_XmlSchemaParticle(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_XmlSchemaParticle && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_XmlSchemaAny && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read58_XmlSchemaAny(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_XmlSchemaElement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read57_XmlSchemaElement(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_XmlSchemaGroupBase && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read51_XmlSchemaGroupBase(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_XmlSchemaAll && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read61_XmlSchemaAll(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_XmlSchemaSequence && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read59_XmlSchemaSequence(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_XmlSchemaChoice && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read60_XmlSchemaChoice(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_XmlSchemaGroupRef && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read50_XmlSchemaGroupRef(isNullable, false, defaultNamespace);
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            throw CreateAbstractTypeException(@"XmlSchemaParticle", @"http://www.w3.org/2001/XMLSchema");
        }

        global::System.Xml.Schema.XmlSchemaIdentityConstraint Read53_XmlSchemaIdentityConstraint(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_XmlSchemaIdentityConstraint && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_XmlSchemaUnique && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read56_XmlSchemaUnique(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_XmlSchemaKeyref && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read55_XmlSchemaKeyref(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_XmlSchemaKey && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read54_XmlSchemaKey(isNullable, false, defaultNamespace);
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaIdentityConstraint o;
            o = new global::System.Xml.Schema.XmlSchemaIdentityConstraint();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.Schema.XmlSchemaObjectCollection a_6 = (global::System.Xml.Schema.XmlSchemaObjectCollection)o.@Fields;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id75_name && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations54 = 0;
            int readerCount54 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id134_selector && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Selector = Read52_XmlSchemaXPath(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id135_field && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read52_XmlSchemaXPath(false, true, defaultNamespace));
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations54, ref readerCount54);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaAnnotated Read17_XmlSchemaAnnotated(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_XmlSchemaAnnotated && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_XmlSchemaNotation && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read68_XmlSchemaNotation(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_XmlSchemaGroup && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read66_XmlSchemaGroup(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_XmlSchemaXPath && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read52_XmlSchemaXPath(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_XmlSchemaIdentityConstraint && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read53_XmlSchemaIdentityConstraint(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_XmlSchemaUnique && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read56_XmlSchemaUnique(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_XmlSchemaKeyref && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read55_XmlSchemaKeyref(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_XmlSchemaKey && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read54_XmlSchemaKey(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_XmlSchemaParticle && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read49_XmlSchemaParticle(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_XmlSchemaAny && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read58_XmlSchemaAny(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_XmlSchemaElement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read57_XmlSchemaElement(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_XmlSchemaGroupBase && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read51_XmlSchemaGroupBase(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_XmlSchemaAll && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read61_XmlSchemaAll(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_XmlSchemaSequence && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read59_XmlSchemaSequence(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_XmlSchemaChoice && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read60_XmlSchemaChoice(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_XmlSchemaGroupRef && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read50_XmlSchemaGroupRef(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id24_XmlSchemaContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read45_XmlSchemaContent(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read63_Item(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id26_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read62_Item(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read47_Item(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id28_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read46_Item(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id29_XmlSchemaContentModel && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read44_XmlSchemaContentModel(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id30_XmlSchemaComplexContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read64_XmlSchemaComplexContent(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id31_XmlSchemaSimpleContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read48_XmlSchemaSimpleContent(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id32_XmlSchemaAnyAttribute && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read42_XmlSchemaAnyAttribute(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id33_XmlSchemaAttributeGroupRef && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read40_XmlSchemaAttributeGroupRef(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id34_XmlSchemaFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read20_XmlSchemaFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id35_XmlSchemaWhiteSpaceFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read33_XmlSchemaWhiteSpaceFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id36_XmlSchemaMinExclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read30_XmlSchemaMinExclusiveFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id37_XmlSchemaMinInclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read29_XmlSchemaMinInclusiveFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id38_XmlSchemaMaxExclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read28_XmlSchemaMaxExclusiveFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id39_XmlSchemaMaxInclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read27_XmlSchemaMaxInclusiveFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id40_XmlSchemaEnumerationFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read26_XmlSchemaEnumerationFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id41_XmlSchemaPatternFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read25_XmlSchemaPatternFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id42_XmlSchemaNumericFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read21_XmlSchemaNumericFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id43_XmlSchemaFractionDigitsFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read32_XmlSchemaFractionDigitsFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id44_XmlSchemaTotalDigitsFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read31_XmlSchemaTotalDigitsFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id45_XmlSchemaMaxLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read24_XmlSchemaMaxLengthFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id46_XmlSchemaMinLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read23_XmlSchemaMinLengthFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id47_XmlSchemaLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read22_XmlSchemaLengthFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id48_XmlSchemaSimpleTypeContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read19_XmlSchemaSimpleTypeContent(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id49_XmlSchemaSimpleTypeUnion && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read36_XmlSchemaSimpleTypeUnion(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id50_XmlSchemaSimpleTypeList && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read35_XmlSchemaSimpleTypeList(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id51_XmlSchemaSimpleTypeRestriction && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read34_XmlSchemaSimpleTypeRestriction(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id52_XmlSchemaType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read18_XmlSchemaType(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id53_XmlSchemaComplexType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read65_XmlSchemaComplexType(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id54_XmlSchemaSimpleType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read37_XmlSchemaSimpleType(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id55_XmlSchemaAttribute && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read39_XmlSchemaAttribute(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id56_XmlSchemaAttributeGroup && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read43_XmlSchemaAttributeGroup(isNullable, false, defaultNamespace);
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::System.Xml.Schema.XmlSchemaAnnotated o;
            o = new global::System.Xml.Schema.XmlSchemaAnnotated();
            global::System.Xml.XmlAttribute[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id85_id && string.Equals(Reader.NamespaceURI, id4_Item))) {
                    o.@Id = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Namespaces == null) o.@Namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Namespaces).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_3 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlAttribute));a_3[ca_3++] = attr;
                }
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations55 = 0;
            int readerCount55 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id99_annotation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id6_Item))) {
                        o.@Annotation = Read14_XmlSchemaAnnotation(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.w3.org/2001/XMLSchema:annotation");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations55, ref readerCount55);
            }
            o.@UnhandledAttributes = (global::System.Xml.XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::System.Xml.Schema.XmlSchemaObject Read8_XmlSchemaObject(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id7_XmlSchemaObject && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item))) {
            }
            else {
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_XmlSchemaAnnotated && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read17_XmlSchemaAnnotated(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_XmlSchemaNotation && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read68_XmlSchemaNotation(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_XmlSchemaGroup && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read66_XmlSchemaGroup(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_XmlSchemaXPath && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read52_XmlSchemaXPath(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_XmlSchemaIdentityConstraint && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read53_XmlSchemaIdentityConstraint(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_XmlSchemaUnique && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read56_XmlSchemaUnique(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_XmlSchemaKeyref && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read55_XmlSchemaKeyref(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_XmlSchemaKey && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read54_XmlSchemaKey(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_XmlSchemaParticle && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read49_XmlSchemaParticle(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_XmlSchemaAny && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read58_XmlSchemaAny(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_XmlSchemaElement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read57_XmlSchemaElement(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_XmlSchemaGroupBase && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read51_XmlSchemaGroupBase(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_XmlSchemaAll && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read61_XmlSchemaAll(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_XmlSchemaSequence && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read59_XmlSchemaSequence(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_XmlSchemaChoice && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read60_XmlSchemaChoice(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_XmlSchemaGroupRef && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read50_XmlSchemaGroupRef(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id24_XmlSchemaContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read45_XmlSchemaContent(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read63_Item(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id26_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read62_Item(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read47_Item(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id28_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read46_Item(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id29_XmlSchemaContentModel && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read44_XmlSchemaContentModel(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id30_XmlSchemaComplexContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read64_XmlSchemaComplexContent(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id31_XmlSchemaSimpleContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read48_XmlSchemaSimpleContent(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id32_XmlSchemaAnyAttribute && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read42_XmlSchemaAnyAttribute(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id33_XmlSchemaAttributeGroupRef && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read40_XmlSchemaAttributeGroupRef(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id34_XmlSchemaFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read20_XmlSchemaFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id35_XmlSchemaWhiteSpaceFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read33_XmlSchemaWhiteSpaceFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id36_XmlSchemaMinExclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read30_XmlSchemaMinExclusiveFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id37_XmlSchemaMinInclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read29_XmlSchemaMinInclusiveFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id38_XmlSchemaMaxExclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read28_XmlSchemaMaxExclusiveFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id39_XmlSchemaMaxInclusiveFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read27_XmlSchemaMaxInclusiveFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id40_XmlSchemaEnumerationFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read26_XmlSchemaEnumerationFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id41_XmlSchemaPatternFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read25_XmlSchemaPatternFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id42_XmlSchemaNumericFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read21_XmlSchemaNumericFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id43_XmlSchemaFractionDigitsFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read32_XmlSchemaFractionDigitsFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id44_XmlSchemaTotalDigitsFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read31_XmlSchemaTotalDigitsFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id45_XmlSchemaMaxLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read24_XmlSchemaMaxLengthFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id46_XmlSchemaMinLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read23_XmlSchemaMinLengthFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id47_XmlSchemaLengthFacet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read22_XmlSchemaLengthFacet(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id48_XmlSchemaSimpleTypeContent && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read19_XmlSchemaSimpleTypeContent(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id49_XmlSchemaSimpleTypeUnion && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read36_XmlSchemaSimpleTypeUnion(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id50_XmlSchemaSimpleTypeList && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read35_XmlSchemaSimpleTypeList(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id51_XmlSchemaSimpleTypeRestriction && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read34_XmlSchemaSimpleTypeRestriction(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id52_XmlSchemaType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read18_XmlSchemaType(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id53_XmlSchemaComplexType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read65_XmlSchemaComplexType(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id54_XmlSchemaSimpleType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read37_XmlSchemaSimpleType(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id55_XmlSchemaAttribute && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read39_XmlSchemaAttribute(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id56_XmlSchemaAttributeGroup && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read43_XmlSchemaAttributeGroup(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id57_XmlSchemaAppInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read13_XmlSchemaAppInfo(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id58_XmlSchemaDocumentation && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read12_XmlSchemaDocumentation(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id59_XmlSchemaAnnotation && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read14_XmlSchemaAnnotation(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id60_XmlSchemaExternal && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read11_XmlSchemaExternal(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id61_XmlSchemaRedefine && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read67_XmlSchemaRedefine(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id62_XmlSchemaImport && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read16_XmlSchemaImport(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id63_XmlSchemaInclude && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read15_XmlSchemaInclude(isNullable, false, defaultNamespace);
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id64_XmlSchema && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id6_Item)))
                    return Read69_XmlSchema(isNullable, false, defaultNamespace);
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            throw CreateAbstractTypeException(@"XmlSchemaObject", @"http://www.w3.org/2001/XMLSchema");
        }

        protected override void InitCallbacks() {
        }

        string id145_minLength;
        string id43_XmlSchemaFractionDigitsFacet;
        string id95_version;
        string id88_title;
        string id132_keyref;
        string id87_updated;
        string id64_XmlSchema;
        string id93_elementFormDefault;
        string id160_anyAttribute;
        string id94_targetNamespace;
        string id129_nillable;
        string id71_XmlSchemaForm;
        string id52_XmlSchemaType;
        string id1_feed;
        string id131_key;
        string id155_whiteSpace;
        string id42_XmlSchemaNumericFacet;
        string id159_complexContent;
        string id38_XmlSchemaMaxExclusiveFacet;
        string id77_term;
        string id9_XmlSchemaNotation;
        string id113_Item;
        string id36_XmlSchemaMinExclusiveFacet;
        string id46_XmlSchemaMinLengthFacet;
        string id26_Item;
        string id47_XmlSchemaLengthFacet;
        string id12_XmlSchemaIdentityConstraint;
        string id123_abstract;
        string id22_XmlSchemaChoice;
        string id53_XmlSchemaComplexType;
        string id82_author;
        string id101_attributeGroup;
        string id134_selector;
        string id13_XmlSchemaUnique;
        string id143_base;
        string id154_fractionDigits;
        string id15_XmlSchemaKey;
        string id34_XmlSchemaFacet;
        string id89_entry;
        string id49_XmlSchemaSimpleTypeUnion;
        string id33_XmlSchemaAttributeGroupRef;
        string id59_XmlSchemaAnnotation;
        string id116_sequence;
        string id97_import;
        string id70_Author;
        string id27_Item;
        string id73_XmlSchemaUse;
        string id108_system;
        string id139_list;
        string id156_value;
        string id25_Item;
        string id61_XmlSchemaRedefine;
        string id68_Content;
        string id111_source;
        string id40_XmlSchemaEnumerationFacet;
        string id66_Entry;
        string id121_processContents;
        string id62_XmlSchemaImport;
        string id126_final;
        string id110_appinfo;
        string id7_XmlSchemaObject;
        string id45_XmlSchemaMaxLengthFacet;
        string id54_XmlSchemaSimpleType;
        string id6_Item;
        string id17_XmlSchemaAny;
        string id153_totalDigits;
        string id60_XmlSchemaExternal;
        string id114_choice;
        string id85_id;
        string id67_Link;
        string id147_pattern;
        string id16_XmlSchemaParticle;
        string id115_all;
        string id112_lang;
        string id99_annotation;
        string id158_simpleContent;
        string id41_XmlSchemaPatternFacet;
        string id30_XmlSchemaComplexContent;
        string id18_XmlSchemaElement;
        string id144_length;
        string id24_XmlSchemaContent;
        string id86_link;
        string id136_xpath;
        string id23_XmlSchemaGroupRef;
        string id11_XmlSchemaXPath;
        string id137_refer;
        string id35_XmlSchemaWhiteSpaceFacet;
        string id92_finalDefault;
        string id14_XmlSchemaKeyref;
        string id149_maxInclusive;
        string id117_minOccurs;
        string id148_enumeration;
        string id122_ref;
        string id146_maxLength;
        string id161_use;
        string id104_element;
        string id21_XmlSchemaSequence;
        string id100_attribute;
        string id133_unique;
        string id106_notation;
        string id151_minInclusive;
        string id8_XmlSchemaAnnotated;
        string id48_XmlSchemaSimpleTypeContent;
        string id50_XmlSchemaSimpleTypeList;
        string id5_schema;
        string id84_content;
        string id74_XmlSchemaContentProcessing;
        string id32_XmlSchemaAnyAttribute;
        string id157_mixed;
        string id127_fixed;
        string id125_default;
        string id130_substitutionGroup;
        string id124_block;
        string id96_include;
        string id58_XmlSchemaDocumentation;
        string id141_memberTypes;
        string id119_any;
        string id109_documentation;
        string id138_restriction;
        string id163_schemaLocation;
        string id105_group;
        string id4_Item;
        string id44_XmlSchemaTotalDigitsFacet;
        string id150_maxExclusive;
        string id90_attributeFormDefault;
        string id57_XmlSchemaAppInfo;
        string id20_XmlSchemaAll;
        string id72_XmlSchemaDerivationMethod;
        string id83_category;
        string id55_XmlSchemaAttribute;
        string id75_name;
        string id29_XmlSchemaContentModel;
        string id63_XmlSchemaInclude;
        string id102_complexType;
        string id81_href;
        string id51_XmlSchemaSimpleTypeRestriction;
        string id37_XmlSchemaMinInclusiveFacet;
        string id79_type;
        string id128_form;
        string id31_XmlSchemaSimpleContent;
        string id142_itemType;
        string id76_uri;
        string id28_Item;
        string id135_field;
        string id19_XmlSchemaGroupBase;
        string id78_label;
        string id91_blockDefault;
        string id3_anyType;
        string id2_httpwwww3org2005Atom;
        string id107_public;
        string id56_XmlSchemaAttributeGroup;
        string id80_rel;
        string id10_XmlSchemaGroup;
        string id140_union;
        string id39_XmlSchemaMaxInclusiveFacet;
        string id152_minExclusive;
        string id120_namespace;
        string id103_simpleType;
        string id98_redefine;
        string id65_Feed;
        string id162_extension;
        string id69_Category;
        string id118_maxOccurs;

        protected override void InitIDs() {
            id145_minLength = Reader.NameTable.Add(@"minLength");
            id43_XmlSchemaFractionDigitsFacet = Reader.NameTable.Add(@"XmlSchemaFractionDigitsFacet");
            id95_version = Reader.NameTable.Add(@"version");
            id88_title = Reader.NameTable.Add(@"title");
            id132_keyref = Reader.NameTable.Add(@"keyref");
            id87_updated = Reader.NameTable.Add(@"updated");
            id64_XmlSchema = Reader.NameTable.Add(@"XmlSchema");
            id93_elementFormDefault = Reader.NameTable.Add(@"elementFormDefault");
            id160_anyAttribute = Reader.NameTable.Add(@"anyAttribute");
            id94_targetNamespace = Reader.NameTable.Add(@"targetNamespace");
            id129_nillable = Reader.NameTable.Add(@"nillable");
            id71_XmlSchemaForm = Reader.NameTable.Add(@"XmlSchemaForm");
            id52_XmlSchemaType = Reader.NameTable.Add(@"XmlSchemaType");
            id1_feed = Reader.NameTable.Add(@"feed");
            id131_key = Reader.NameTable.Add(@"key");
            id155_whiteSpace = Reader.NameTable.Add(@"whiteSpace");
            id42_XmlSchemaNumericFacet = Reader.NameTable.Add(@"XmlSchemaNumericFacet");
            id159_complexContent = Reader.NameTable.Add(@"complexContent");
            id38_XmlSchemaMaxExclusiveFacet = Reader.NameTable.Add(@"XmlSchemaMaxExclusiveFacet");
            id77_term = Reader.NameTable.Add(@"term");
            id9_XmlSchemaNotation = Reader.NameTable.Add(@"XmlSchemaNotation");
            id113_Item = Reader.NameTable.Add(@"http://www.w3.org/XML/1998/namespace");
            id36_XmlSchemaMinExclusiveFacet = Reader.NameTable.Add(@"XmlSchemaMinExclusiveFacet");
            id46_XmlSchemaMinLengthFacet = Reader.NameTable.Add(@"XmlSchemaMinLengthFacet");
            id26_Item = Reader.NameTable.Add(@"XmlSchemaComplexContentRestriction");
            id47_XmlSchemaLengthFacet = Reader.NameTable.Add(@"XmlSchemaLengthFacet");
            id12_XmlSchemaIdentityConstraint = Reader.NameTable.Add(@"XmlSchemaIdentityConstraint");
            id123_abstract = Reader.NameTable.Add(@"abstract");
            id22_XmlSchemaChoice = Reader.NameTable.Add(@"XmlSchemaChoice");
            id53_XmlSchemaComplexType = Reader.NameTable.Add(@"XmlSchemaComplexType");
            id82_author = Reader.NameTable.Add(@"author");
            id101_attributeGroup = Reader.NameTable.Add(@"attributeGroup");
            id134_selector = Reader.NameTable.Add(@"selector");
            id13_XmlSchemaUnique = Reader.NameTable.Add(@"XmlSchemaUnique");
            id143_base = Reader.NameTable.Add(@"base");
            id154_fractionDigits = Reader.NameTable.Add(@"fractionDigits");
            id15_XmlSchemaKey = Reader.NameTable.Add(@"XmlSchemaKey");
            id34_XmlSchemaFacet = Reader.NameTable.Add(@"XmlSchemaFacet");
            id89_entry = Reader.NameTable.Add(@"entry");
            id49_XmlSchemaSimpleTypeUnion = Reader.NameTable.Add(@"XmlSchemaSimpleTypeUnion");
            id33_XmlSchemaAttributeGroupRef = Reader.NameTable.Add(@"XmlSchemaAttributeGroupRef");
            id59_XmlSchemaAnnotation = Reader.NameTable.Add(@"XmlSchemaAnnotation");
            id116_sequence = Reader.NameTable.Add(@"sequence");
            id97_import = Reader.NameTable.Add(@"import");
            id70_Author = Reader.NameTable.Add(@"Author");
            id27_Item = Reader.NameTable.Add(@"XmlSchemaSimpleContentExtension");
            id73_XmlSchemaUse = Reader.NameTable.Add(@"XmlSchemaUse");
            id108_system = Reader.NameTable.Add(@"system");
            id139_list = Reader.NameTable.Add(@"list");
            id156_value = Reader.NameTable.Add(@"value");
            id25_Item = Reader.NameTable.Add(@"XmlSchemaComplexContentExtension");
            id61_XmlSchemaRedefine = Reader.NameTable.Add(@"XmlSchemaRedefine");
            id68_Content = Reader.NameTable.Add(@"Content");
            id111_source = Reader.NameTable.Add(@"source");
            id40_XmlSchemaEnumerationFacet = Reader.NameTable.Add(@"XmlSchemaEnumerationFacet");
            id66_Entry = Reader.NameTable.Add(@"Entry");
            id121_processContents = Reader.NameTable.Add(@"processContents");
            id62_XmlSchemaImport = Reader.NameTable.Add(@"XmlSchemaImport");
            id126_final = Reader.NameTable.Add(@"final");
            id110_appinfo = Reader.NameTable.Add(@"appinfo");
            id7_XmlSchemaObject = Reader.NameTable.Add(@"XmlSchemaObject");
            id45_XmlSchemaMaxLengthFacet = Reader.NameTable.Add(@"XmlSchemaMaxLengthFacet");
            id54_XmlSchemaSimpleType = Reader.NameTable.Add(@"XmlSchemaSimpleType");
            id6_Item = Reader.NameTable.Add(@"http://www.w3.org/2001/XMLSchema");
            id17_XmlSchemaAny = Reader.NameTable.Add(@"XmlSchemaAny");
            id153_totalDigits = Reader.NameTable.Add(@"totalDigits");
            id60_XmlSchemaExternal = Reader.NameTable.Add(@"XmlSchemaExternal");
            id114_choice = Reader.NameTable.Add(@"choice");
            id85_id = Reader.NameTable.Add(@"id");
            id67_Link = Reader.NameTable.Add(@"Link");
            id147_pattern = Reader.NameTable.Add(@"pattern");
            id16_XmlSchemaParticle = Reader.NameTable.Add(@"XmlSchemaParticle");
            id115_all = Reader.NameTable.Add(@"all");
            id112_lang = Reader.NameTable.Add(@"lang");
            id99_annotation = Reader.NameTable.Add(@"annotation");
            id158_simpleContent = Reader.NameTable.Add(@"simpleContent");
            id41_XmlSchemaPatternFacet = Reader.NameTable.Add(@"XmlSchemaPatternFacet");
            id30_XmlSchemaComplexContent = Reader.NameTable.Add(@"XmlSchemaComplexContent");
            id18_XmlSchemaElement = Reader.NameTable.Add(@"XmlSchemaElement");
            id144_length = Reader.NameTable.Add(@"length");
            id24_XmlSchemaContent = Reader.NameTable.Add(@"XmlSchemaContent");
            id86_link = Reader.NameTable.Add(@"link");
            id136_xpath = Reader.NameTable.Add(@"xpath");
            id23_XmlSchemaGroupRef = Reader.NameTable.Add(@"XmlSchemaGroupRef");
            id11_XmlSchemaXPath = Reader.NameTable.Add(@"XmlSchemaXPath");
            id137_refer = Reader.NameTable.Add(@"refer");
            id35_XmlSchemaWhiteSpaceFacet = Reader.NameTable.Add(@"XmlSchemaWhiteSpaceFacet");
            id92_finalDefault = Reader.NameTable.Add(@"finalDefault");
            id14_XmlSchemaKeyref = Reader.NameTable.Add(@"XmlSchemaKeyref");
            id149_maxInclusive = Reader.NameTable.Add(@"maxInclusive");
            id117_minOccurs = Reader.NameTable.Add(@"minOccurs");
            id148_enumeration = Reader.NameTable.Add(@"enumeration");
            id122_ref = Reader.NameTable.Add(@"ref");
            id146_maxLength = Reader.NameTable.Add(@"maxLength");
            id161_use = Reader.NameTable.Add(@"use");
            id104_element = Reader.NameTable.Add(@"element");
            id21_XmlSchemaSequence = Reader.NameTable.Add(@"XmlSchemaSequence");
            id100_attribute = Reader.NameTable.Add(@"attribute");
            id133_unique = Reader.NameTable.Add(@"unique");
            id106_notation = Reader.NameTable.Add(@"notation");
            id151_minInclusive = Reader.NameTable.Add(@"minInclusive");
            id8_XmlSchemaAnnotated = Reader.NameTable.Add(@"XmlSchemaAnnotated");
            id48_XmlSchemaSimpleTypeContent = Reader.NameTable.Add(@"XmlSchemaSimpleTypeContent");
            id50_XmlSchemaSimpleTypeList = Reader.NameTable.Add(@"XmlSchemaSimpleTypeList");
            id5_schema = Reader.NameTable.Add(@"schema");
            id84_content = Reader.NameTable.Add(@"content");
            id74_XmlSchemaContentProcessing = Reader.NameTable.Add(@"XmlSchemaContentProcessing");
            id32_XmlSchemaAnyAttribute = Reader.NameTable.Add(@"XmlSchemaAnyAttribute");
            id157_mixed = Reader.NameTable.Add(@"mixed");
            id127_fixed = Reader.NameTable.Add(@"fixed");
            id125_default = Reader.NameTable.Add(@"default");
            id130_substitutionGroup = Reader.NameTable.Add(@"substitutionGroup");
            id124_block = Reader.NameTable.Add(@"block");
            id96_include = Reader.NameTable.Add(@"include");
            id58_XmlSchemaDocumentation = Reader.NameTable.Add(@"XmlSchemaDocumentation");
            id141_memberTypes = Reader.NameTable.Add(@"memberTypes");
            id119_any = Reader.NameTable.Add(@"any");
            id109_documentation = Reader.NameTable.Add(@"documentation");
            id138_restriction = Reader.NameTable.Add(@"restriction");
            id163_schemaLocation = Reader.NameTable.Add(@"schemaLocation");
            id105_group = Reader.NameTable.Add(@"group");
            id4_Item = Reader.NameTable.Add(@"");
            id44_XmlSchemaTotalDigitsFacet = Reader.NameTable.Add(@"XmlSchemaTotalDigitsFacet");
            id150_maxExclusive = Reader.NameTable.Add(@"maxExclusive");
            id90_attributeFormDefault = Reader.NameTable.Add(@"attributeFormDefault");
            id57_XmlSchemaAppInfo = Reader.NameTable.Add(@"XmlSchemaAppInfo");
            id20_XmlSchemaAll = Reader.NameTable.Add(@"XmlSchemaAll");
            id72_XmlSchemaDerivationMethod = Reader.NameTable.Add(@"XmlSchemaDerivationMethod");
            id83_category = Reader.NameTable.Add(@"category");
            id55_XmlSchemaAttribute = Reader.NameTable.Add(@"XmlSchemaAttribute");
            id75_name = Reader.NameTable.Add(@"name");
            id29_XmlSchemaContentModel = Reader.NameTable.Add(@"XmlSchemaContentModel");
            id63_XmlSchemaInclude = Reader.NameTable.Add(@"XmlSchemaInclude");
            id102_complexType = Reader.NameTable.Add(@"complexType");
            id81_href = Reader.NameTable.Add(@"href");
            id51_XmlSchemaSimpleTypeRestriction = Reader.NameTable.Add(@"XmlSchemaSimpleTypeRestriction");
            id37_XmlSchemaMinInclusiveFacet = Reader.NameTable.Add(@"XmlSchemaMinInclusiveFacet");
            id79_type = Reader.NameTable.Add(@"type");
            id128_form = Reader.NameTable.Add(@"form");
            id31_XmlSchemaSimpleContent = Reader.NameTable.Add(@"XmlSchemaSimpleContent");
            id142_itemType = Reader.NameTable.Add(@"itemType");
            id76_uri = Reader.NameTable.Add(@"uri");
            id28_Item = Reader.NameTable.Add(@"XmlSchemaSimpleContentRestriction");
            id135_field = Reader.NameTable.Add(@"field");
            id19_XmlSchemaGroupBase = Reader.NameTable.Add(@"XmlSchemaGroupBase");
            id78_label = Reader.NameTable.Add(@"label");
            id91_blockDefault = Reader.NameTable.Add(@"blockDefault");
            id3_anyType = Reader.NameTable.Add(@"anyType");
            id2_httpwwww3org2005Atom = Reader.NameTable.Add(@"http://www.w3.org/2005/Atom");
            id107_public = Reader.NameTable.Add(@"public");
            id56_XmlSchemaAttributeGroup = Reader.NameTable.Add(@"XmlSchemaAttributeGroup");
            id80_rel = Reader.NameTable.Add(@"rel");
            id10_XmlSchemaGroup = Reader.NameTable.Add(@"XmlSchemaGroup");
            id140_union = Reader.NameTable.Add(@"union");
            id39_XmlSchemaMaxInclusiveFacet = Reader.NameTable.Add(@"XmlSchemaMaxInclusiveFacet");
            id152_minExclusive = Reader.NameTable.Add(@"minExclusive");
            id120_namespace = Reader.NameTable.Add(@"namespace");
            id103_simpleType = Reader.NameTable.Add(@"simpleType");
            id98_redefine = Reader.NameTable.Add(@"redefine");
            id65_Feed = Reader.NameTable.Add(@"Feed");
            id162_extension = Reader.NameTable.Add(@"extension");
            id69_Category = Reader.NameTable.Add(@"Category");
            id118_maxOccurs = Reader.NameTable.Add(@"maxOccurs");
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class FeedSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"feed", this.DefaultNamespace ?? @"http://www.w3.org/2005/Atom");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write70_feed(objectToSerialize, this.DefaultNamespace, @"http://www.w3.org/2005/Atom");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read70_feed(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ObjectSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"anyType", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write71_anyType(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read71_anyType(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class XmlSchemaSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"schema", this.DefaultNamespace ?? @"http://www.w3.org/2001/XMLSchema");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write72_schema(objectToSerialize, this.DefaultNamespace, @"http://www.w3.org/2001/XMLSchema");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read72_schema(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System_Runtime_Extensions::System.Collections.Hashtable readMethods = null;
        public override System_Runtime_Extensions::System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System_Runtime_Extensions::System.Collections.Hashtable _tmp = new System_Runtime_Extensions::System.Collections.Hashtable();
                    _tmp[@"RedditRss.Models.Feed:http://www.w3.org/2005/Atom:feed:True:"] = @"Read70_feed";
                    _tmp[@"System.Object::"] = @"Read71_anyType";
                    _tmp[@"System.Xml.Schema.XmlSchema:http://www.w3.org/2001/XMLSchema:schema:True:"] = @"Read72_schema";
                    _tmp[@"System.Object::"] = @"Read73_anyType";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System_Runtime_Extensions::System.Collections.Hashtable writeMethods = null;
        public override System_Runtime_Extensions::System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System_Runtime_Extensions::System.Collections.Hashtable _tmp = new System_Runtime_Extensions::System.Collections.Hashtable();
                    _tmp[@"RedditRss.Models.Feed:http://www.w3.org/2005/Atom:feed:True:"] = @"Write70_feed";
                    _tmp[@"System.Object::"] = @"Write71_anyType";
                    _tmp[@"System.Xml.Schema.XmlSchema:http://www.w3.org/2001/XMLSchema:schema:True:"] = @"Write72_schema";
                    _tmp[@"System.Object::"] = @"Write73_anyType";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System_Runtime_Extensions::System.Collections.Hashtable typedSerializers = null;
        public override System_Runtime_Extensions::System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System_Runtime_Extensions::System.Collections.Hashtable _tmp = new System_Runtime_Extensions::System.Collections.Hashtable();
                    _tmp.Add(@"RedditRss.Models.Feed:http://www.w3.org/2005/Atom:feed:True:", new FeedSerializer());
                    _tmp.Add(@"System.Xml.Schema.XmlSchema:http://www.w3.org/2001/XMLSchema:schema:True:", new XmlSchemaSerializer());
                    _tmp.Add(@"System.Object::", new ObjectSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::RedditRss.Models.Feed)) return true;
            if (type == typeof(global::System.Object)) return true;
            if (type == typeof(global::System.Xml.Schema.XmlSchema)) return true;
            if (type == typeof(global::System.Reflection.TypeInfo)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::RedditRss.Models.Feed)) return new FeedSerializer();
            if (type == typeof(global::System.Object)) return new ObjectSerializer();
            if (type == typeof(global::System.Xml.Schema.XmlSchema)) return new XmlSchemaSerializer();
            if (type == typeof(global::System.Object)) return new ObjectSerializer();
            return null;
        }
        public static global::System.Xml.Serialization.XmlSerializerImplementation GetXmlSerializerContract() { return new XmlSerializerContract(); }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public static class ActivatorHelper {
        public static object CreateInstance(System.Type type) {
            System.Reflection.TypeInfo ti = System.Reflection.IntrospectionExtensions.GetTypeInfo(type);
            foreach (System.Reflection.ConstructorInfo ci in ti.DeclaredConstructors) {
                if (!ci.IsStatic && ci.GetParameters().Length == 0) {
                    return ci.Invoke(null);
                }
            }
            return System.Activator.CreateInstance(type);
        }
    }
}
