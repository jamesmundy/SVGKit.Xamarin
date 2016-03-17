using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreAnimation;
using CoreGraphics;

namespace SVGKitBindings {

	// @interface DOMHelperUtilities : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface DOMHelperUtilities {

		// +(void)privateGetElementsByName:(NSString *)name inNamespace:(NSString *)namespaceURI childrenOfElement:(Node *)parent addToList:(NodeList *)accumulator;
		[Static, Export ("privateGetElementsByName:inNamespace:childrenOfElement:addToList:")]
		void PrivateGetElementsByName (string name, string namespaceURI, Node parent, NodeList accumulator);

		// +(Element *)privateGetElementById:(NSString *)idValue childrenOfElement:(Node *)parent;
		[Static, Export ("privateGetElementById:childrenOfElement:")]
		Element PrivateGetElementById (string idValue, Node parent);
	}

	// @interface Node : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface Node {

		// -(id)initType:(DOMNodeType)nt name:(NSString *)n;
		[Export ("initType:name:")]
		IntPtr Constructor (DOMNodeType nt, string n);

		// -(id)initType:(DOMNodeType)nt name:(NSString *)n value:(NSString *)v;
		[Export ("initType:name:value:")]
		IntPtr Constructor (DOMNodeType nt, string n, string v);

		// -(id)initType:(DOMNodeType)nt name:(NSString *)n value:(NSString *)v inNamespace:(NSString *)nsURI;
		[Export ("initType:name:value:inNamespace:")]
		IntPtr Constructor (DOMNodeType nt, string n, string v, string nsURI);

		// @property (readonly, retain, nonatomic) NSString * nodeName;
		[Export ("nodeName", ArgumentSemantic.Retain)]
		string NodeName { get; set; }

		// @property (readonly, retain, nonatomic) NSString * nodeValue;
		[Export ("nodeValue", ArgumentSemantic.Retain)]
		string NodeValue { get; set; }

		// @property (readonly, nonatomic) DOMNodeType nodeType;
		[Export ("nodeType")]
		DOMNodeType NodeType { get; set; }

		// @property (readonly, assign, nonatomic) Node * parentNode;
		[Export ("parentNode", ArgumentSemantic.UnsafeUnretained)]
		Node ParentNode { get; set; }

		// @property (readonly, retain, nonatomic) NodeList * childNodes;
		[Export ("childNodes", ArgumentSemantic.Retain)]
		NodeList ChildNodes { get; set; }

		// @property (readonly, assign, nonatomic) Node * firstChild;
		[Export ("firstChild", ArgumentSemantic.UnsafeUnretained)]
		Node FirstChild { get; }

		// @property (readonly, assign, nonatomic) Node * lastChild;
		[Export ("lastChild", ArgumentSemantic.UnsafeUnretained)]
		Node LastChild { get; }

		// @property (readonly, assign, nonatomic) Node * previousSibling;
		[Export ("previousSibling", ArgumentSemantic.UnsafeUnretained)]
		Node PreviousSibling { get; }

		// @property (readonly, assign, nonatomic) Node * nextSibling;
		[Export ("nextSibling", ArgumentSemantic.UnsafeUnretained)]
		Node NextSibling { get; }

		// @property (readonly, retain, nonatomic) NamedNodeMap * attributes;
		[Export ("attributes", ArgumentSemantic.Retain)]
		NamedNodeMap Attributes { get; set; }

		// @property (readonly, assign, nonatomic) Document * ownerDocument;
		[Export ("ownerDocument", ArgumentSemantic.UnsafeUnretained)]
		Document OwnerDocument { get; set; }

		// @property (nonatomic) BOOL hasChildNodes;
		[Export ("hasChildNodes")]
		bool HasChildNodes { get; set; }

		// @property (readonly, retain, nonatomic) NSString * namespaceURI;
		[Export ("namespaceURI", ArgumentSemantic.Retain)]
		string NamespaceURI { get; set; }

		// @property (readonly, retain, nonatomic) NSString * prefix;
		[Export ("prefix", ArgumentSemantic.Retain)]
		string Prefix { get; set; }

		// @property (readonly, retain, nonatomic) NSString * localName;
		[Export ("localName", ArgumentSemantic.Retain)]
		string LocalName { get; set; }

		// @property (nonatomic) BOOL hasAttributes;
		[Export ("hasAttributes")]
		bool HasAttributes { get; set; }

		// @property (readonly, nonatomic) NSString * textContent;
		[Export ("textContent")]
		string TextContent { get; }

		// -(Node *)insertBefore:(Node *)newChild refChild:(Node *)refChild;
		[Export ("insertBefore:refChild:")]
		Node InsertBefore (Node newChild, Node refChild);

		// -(Node *)replaceChild:(Node *)newChild oldChild:(Node *)oldChild;
		[Export ("replaceChild:oldChild:")]
		Node ReplaceChild (Node newChild, Node oldChild);

		// -(Node *)removeChild:(Node *)oldChild;
		[Export ("removeChild:")]
		Node RemoveChild (Node oldChild);

		// -(Node *)appendChild:(Node *)newChild;
		[Export ("appendChild:")]
		Node AppendChild (Node newChild);

		// -(Node *)cloneNode:(BOOL)deep;
		[Export ("cloneNode:")]
		Node CloneNode (bool deep);

		// -(void)normalize;
		[Export ("normalize")]
		void Normalize ();

		// -(BOOL)isSupportedFeature:(NSString *)feature version:(NSString *)version;
		[Export ("isSupportedFeature:version:")]
		bool IsSupportedFeature (string feature, string version);

		// -(void)appendXMLToString:(NSMutableString *)outputString availableNamespaces:(NSDictionary *)prefixesByKNOWNNamespace activeNamespaces:(NSMutableDictionary *)prefixesByACTIVENamespace;
		[Export ("appendXMLToString:availableNamespaces:activeNamespaces:")]
		void AppendXMLToString (NSMutableString outputString, NSDictionary prefixesByKNOWNNamespace, NSMutableDictionary prefixesByACTIVENamespace);
	}

	// @interface Attr : Node
	[Protocol]
	[BaseType (typeof (Node))]
	interface Attr {

		// -(id)initWithName:(NSString *)n value:(NSString *)v;
		[Export ("initWithName:value:")]
		IntPtr Constructor (string n, string v);

		// -(id)initWithNamespace:(NSString *)ns qualifiedName:(NSString *)qn value:(NSString *)v;
		[Export ("initWithNamespace:qualifiedName:value:")]
		IntPtr Constructor (string ns, string qn, string v);

		// @property (readonly, retain, nonatomic) NSString * name;
		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; }

		// @property (readonly, nonatomic) BOOL specified;
		[Export ("specified")]
		bool Specified { get; }

		// @property (readonly, retain, nonatomic) NSString * value;
		[Export ("value", ArgumentSemantic.Retain)]
		string Value { get; }

		// @property (readonly, retain, nonatomic) Element * ownerElement;
		[Export ("ownerElement", ArgumentSemantic.Retain)]
		Element OwnerElement { get; }
	}

	// @interface NodeList : NSObject <NSFastEnumeration>
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface NodeList {

		// @property (readonly) long length;
		[Export ("length")]
		nint Length { get; }

		// -(Node *)item:(int)index;
		[Export ("item:")]
		Node Item (int index);
	}

	// @interface Element : Node
	[Protocol]
	[BaseType (typeof (Node))]
	interface Element {

		// -(id)initWithLocalName:(NSString *)n attributes:(NSMutableDictionary *)attributes;
		[Export ("initWithLocalName:attributes:")]
		IntPtr Constructor (string n, NSMutableDictionary attributes);

		// -(id)initWithQualifiedName:(NSString *)n inNameSpaceURI:(NSString *)nsURI attributes:(NSMutableDictionary *)attributes;
		[Export ("initWithQualifiedName:inNameSpaceURI:attributes:")]
		IntPtr Constructor (string n, string nsURI, NSMutableDictionary attributes);

		// @property (readonly, retain, nonatomic) NSString * tagName;
		[Export ("tagName", ArgumentSemantic.Retain)]
		string TagName { get; }

		// -(NSString *)getAttribute:(NSString *)name;
		[Export ("getAttribute:")]
		string GetAttribute (string name);

		// -(void)setAttribute:(NSString *)name value:(NSString *)value;
		[Export ("setAttribute:value:")]
		void SetAttribute (string name, string value);

		// -(void)removeAttribute:(NSString *)name;
		[Export ("removeAttribute:")]
		void RemoveAttribute (string name);

		// -(Attr *)getAttributeNode:(NSString *)name;
		[Export ("getAttributeNode:")]
		Attr GetAttributeNode (string name);

		// -(Attr *)setAttributeNode:(Attr *)newAttr;
		[Export ("setAttributeNode:")]
		Attr SetAttributeNode (Attr newAttr);

		// -(Attr *)removeAttributeNode:(Attr *)oldAttr;
		[Export ("removeAttributeNode:")]
		Attr RemoveAttributeNode (Attr oldAttr);

		// -(NodeList *)getElementsByTagName:(NSString *)name;
		[Export ("getElementsByTagName:")]
		NodeList GetElementsByTagName (string name);

		// -(NSString *)getAttributeNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("getAttributeNS:localName:")]
		string GetAttributeNS (string namespaceURI, string localName);

		// -(void)setAttributeNS:(NSString *)namespaceURI qualifiedName:(NSString *)qualifiedName value:(NSString *)value;
		[Export ("setAttributeNS:qualifiedName:value:")]
		void SetAttributeNS (string namespaceURI, string qualifiedName, string value);

		// -(void)removeAttributeNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("removeAttributeNS:localName:")]
		void RemoveAttributeNS (string namespaceURI, string localName);

		// -(Attr *)getAttributeNodeNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("getAttributeNodeNS:localName:")]
		Attr GetAttributeNodeNS (string namespaceURI, string localName);

		// -(Attr *)setAttributeNodeNS:(Attr *)newAttr;
		[Export ("setAttributeNodeNS:")]
		Attr SetAttributeNodeNS (Attr newAttr);

		// -(NodeList *)getElementsByTagNameNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("getElementsByTagNameNS:localName:")]
		NodeList GetElementsByTagNameNS (string namespaceURI, string localName);

		// -(BOOL)hasAttribute:(NSString *)name;
		[Export ("hasAttribute:")]
		bool HasAttribute (string name);

		// -(BOOL)hasAttributeNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("hasAttributeNS:localName:")]
		bool HasAttributeNS (string namespaceURI, string localName);
	}

	// @interface CSSValue : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface CSSValue {

		// @property (retain, nonatomic) NSString * cssText;
		[Export ("cssText", ArgumentSemantic.Retain)]
		string CssText { get; set; }

		// @property (nonatomic) CSSUnitType cssValueType;
		[Export ("cssValueType")]
		CSSUnitType CssValueType { get; set; }
	}

	// @interface CSSRule : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface CSSRule {

		// @property (nonatomic) unsigned short type;
		[Export ("type")]
		ushort Type { get; set; }

		// @property (retain, nonatomic) NSString * cssText;
		[Export ("cssText", ArgumentSemantic.Retain)]
		string CssText { get; set; }

//		// @property (retain, nonatomic) CSSStyleSheet * parentStyleSheet;
//		[Export ("parentStyleSheet", ArgumentSemantic.Retain)]
//		CSSStyleSheet ParentStyleSheet { get; set; }

		// @property (retain, nonatomic) CSSRule * parentRule;
		[Export ("parentRule", ArgumentSemantic.Retain)]
		CSSRule ParentRule { get; set; }
	}

	// @interface CSSStyleDeclaration : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface CSSStyleDeclaration {

		// @property (retain, nonatomic) NSString * cssText;
		[Export ("cssText", ArgumentSemantic.Retain)]
		string CssText { get; set; }

		// @property (nonatomic) unsigned long length;
		[Export ("length")]
		nuint Length { get; set; }

		// @property (retain, nonatomic) CSSRule * parentRule;
		[Export ("parentRule", ArgumentSemantic.Retain)]
		CSSRule ParentRule { get; set; }

		// -(NSString *)getPropertyValue:(NSString *)propertyName;
		[Export ("getPropertyValue:")]
		string GetPropertyValue (string propertyName);

		// -(CSSValue *)getPropertyCSSValue:(NSString *)propertyName;
		[Export ("getPropertyCSSValue:")]
		CSSValue GetPropertyCSSValue (string propertyName);

		// -(NSString *)removeProperty:(NSString *)propertyName;
		[Export ("removeProperty:")]
		string RemoveProperty (string propertyName);

		// -(NSString *)getPropertyPriority:(NSString *)propertyName;
		[Export ("getPropertyPriority:")]
		string GetPropertyPriority (string propertyName);

		// -(void)setProperty:(NSString *)propertyName value:(NSString *)value priority:(NSString *)priority;
		[Export ("setProperty:value:priority:")]
		void SetProperty (string propertyName, string value, string priority);

		// -(NSString *)item:(long)index;
		[Export ("item:")]
		string Item (nint index);
	}

	// @protocol SVGStylable <NSObject> removed model from here
	[Model]
	[BaseType (typeof (NSObject))]
	interface SVGStylable {

		// @property (retain, nonatomic) NSString * className;
		[Export ("className", ArgumentSemantic.Retain)]
		string ClassName { get; set; }

		// @property (retain, nonatomic) CSSStyleDeclaration * style;
		[Export ("style", ArgumentSemantic.Retain)]
		CSSStyleDeclaration Style { get; set; }

		// @required -(CSSValue *)getPresentationAttribute:(NSString *)name;
		[Export ("getPresentationAttribute:")]
		[Abstract]
		CSSValue GetPresentationAttribute (string name);
	}

	// @interface SVGLength : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGLength {

		// @property (readonly, nonatomic) SVG_LENGTH_TYPE unitType;
		[Export ("unitType")]
		SVG_LENGTH_TYPE UnitType { get; }

		// @property (nonatomic) float value;
		[Export ("value")]
		float Value { get; set; }

		// @property (nonatomic) float valueInSpecifiedUnits;
		[Export ("valueInSpecifiedUnits")]
		float ValueInSpecifiedUnits { get; set; }

		// @property (retain, nonatomic) NSString * valueAsString;
		[Export ("valueAsString", ArgumentSemantic.Retain)]
		string ValueAsString { get; set; }

		// -(void)newValueSpecifiedUnits:(SVG_LENGTH_TYPE)unitType valueInSpecifiedUnits:(float)valueInSpecifiedUnits;
		[Export ("newValueSpecifiedUnits:valueInSpecifiedUnits:")]
		void NewValueSpecifiedUnits (SVG_LENGTH_TYPE unitType, float valueInSpecifiedUnits);

		// -(void)convertToSpecifiedUnits:(SVG_LENGTH_TYPE)unitType;
		[Export ("convertToSpecifiedUnits:")]
		void ConvertToSpecifiedUnits (SVG_LENGTH_TYPE unitType);

		// +(SVGLength *)svgLengthZero;
		[Static, Export ("svgLengthZero")]
		SVGLength SvgLengthZero ();

		// +(SVGLength *)svgLengthFromNSString:(NSString *)s;
		[Static, Export ("svgLengthFromNSString:")]
		SVGLength SvgLengthFromNSString (string s);

		// -(float)pixelsValue;
		[Export ("pixelsValue")]
		float PixelsValue ();

		// -(float)numberValue;
		[Export ("numberValue")]
		float NumberValue ();
	}

	// @interface SVGElement : Element <SVGStylable>
	[Protocol]
	[BaseType (typeof (Element))]
	interface SVGElement : SVGStylable {

		// -(id)initWithLocalName:(NSString *)n attributes:(NSMutableDictionary *)attributes;
		[Export ("initWithLocalName:attributes:")]
		IntPtr Constructor (string n, NSMutableDictionary attributes);

		// -(id)initWithQualifiedName:(NSString *)n inNameSpaceURI:(NSString *)nsURI attributes:(NSMutableDictionary *)attributes;
		[Export ("initWithQualifiedName:inNameSpaceURI:attributes:")]
		IntPtr Constructor (string n, string nsURI, NSMutableDictionary attributes);

		// @property (readwrite, retain, nonatomic) NSString * identifier;
		[Export ("identifier", ArgumentSemantic.Retain)]
		string Identifier { get; set; }

		// @property (retain, nonatomic) NSString * xmlbase;
		[Export ("xmlbase", ArgumentSemantic.Retain)]
		string Xmlbase { get; set; }

		// @property (assign, nonatomic) SVGSVGElement * rootOfCurrentDocumentFragment;
		[Export ("rootOfCurrentDocumentFragment", ArgumentSemantic.UnsafeUnretained)]
		SVGSVGElement RootOfCurrentDocumentFragment { get; set; }

		// @property (assign, nonatomic) SVGElement * viewportElement;
		[Export ("viewportElement", ArgumentSemantic.UnsafeUnretained)]
		SVGElement ViewportElement { get; set; }

		// -(void)reCalculateAndSetViewportElementReferenceUsingFirstSVGAncestor:(SVGElement *)firstAncestor;
		[Export ("reCalculateAndSetViewportElementReferenceUsingFirstSVGAncestor:")]
		void ReCalculateAndSetViewportElementReferenceUsingFirstSVGAncestor (SVGElement firstAncestor);

		// -(SVGLength *)getAttributeAsSVGLength:(NSString *)attributeName;
		[Export ("getAttributeAsSVGLength:")]
		SVGLength GetAttributeAsSVGLength (string attributeName);

		// -(NSString *)cascadedValueForStylableProperty:(NSString *)stylableProperty;
		[Export ("cascadedValueForStylableProperty:")]
		string CascadedValueForStylableProperty (string stylableProperty);
	}

	// @protocol ConverterSVGToCALayer <NSObject>
	[Model]
	[BaseType (typeof (NSObject))]
	interface ConverterSVGToCALayer {

		// @required -(CALayer *)newLayer;
		[Export ("newLayer")]
		[Abstract]
		CALayer NewLayer ();

		// @required -(void)layoutLayer:(CALayer *)layer;
		[Export ("layoutLayer:")]
		[Abstract]
		void LayoutLayer (CALayer layer);
	}

	// @protocol SVGTransformable <NSObject>
	[Model]
	[BaseType (typeof (NSObject))]
	interface SVGTransformable {

		// @property (nonatomic) CGAffineTransform transform;
		[Export ("transform")]
		CGAffineTransform Transform { get; set; }
	}

	// @interface BaseClassForAllSVGBasicShapes : SVGElement <SVGStylable, SVGTransformable, ConverterSVGToCALayer>
	[Protocol]
	[BaseType (typeof (SVGElement))]
	interface BaseClassForAllSVGBasicShapes : SVGStylable, SVGTransformable, ConverterSVGToCALayer {

		// @property (readonly, nonatomic) CGPathRef pathForShapeInRelativeCoords;
		[Export ("pathForShapeInRelativeCoords")]
		CGPath PathForShapeInRelativeCoords { get; set; }
	}

	// @interface SVGEllipseElement : BaseClassForAllSVGBasicShapes
	[Protocol]
	[BaseType (typeof (BaseClassForAllSVGBasicShapes))]
	interface SVGEllipseElement {

		// @property (readonly, nonatomic) CGFloat cx;
		[Export ("cx")]
		nfloat Cx { get; }

		// @property (readonly, nonatomic) CGFloat cy;
		[Export ("cy")]
		nfloat Cy { get; }

		// @property (readonly, nonatomic) CGFloat rx;
		[Export ("rx")]
		nfloat Rx { get; }

		// @property (readonly, nonatomic) CGFloat ry;
		[Export ("ry")]
		nfloat Ry { get; }
	}

	// @interface SVGCircleElement : SVGEllipseElement
	[Protocol]
	[BaseType (typeof (SVGEllipseElement))]
	interface SVGCircleElement {

		// @property (readonly, nonatomic) CGFloat r;
		[Export ("r")]
		nfloat R { get; }
	}

	// @interface StyleSheet : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface StyleSheet {

		// @property (retain, nonatomic) NSString * type;
		[Export ("type", ArgumentSemantic.Retain)]
		string Type { get; set; }

		// @property (nonatomic) BOOL disabled;
		[Export ("disabled")]
		bool Disabled { get; set; }

		// @property (retain, nonatomic) Node * ownerNode;
		[Export ("ownerNode", ArgumentSemantic.Retain)]
		Node OwnerNode { get; set; }

		// @property (retain, nonatomic) StyleSheet * parentStyleSheet;
		[Export ("parentStyleSheet", ArgumentSemantic.Retain)]
		StyleSheet ParentStyleSheet { get; set; }

		// @property (retain, nonatomic) NSString * href;
		[Export ("href", ArgumentSemantic.Retain)]
		string Href { get; set; }

		// @property (retain, nonatomic) NSString * title;
		[Export ("title", ArgumentSemantic.Retain)]
		string Title { get; set; }

//		// @property (retain, nonatomic) MediaList * media;
//		[Export ("media", ArgumentSemantic.Retain)]
//		MediaList Media { get; set; }
	}

	// @interface StyleSheetList : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface StyleSheetList {

		// @property (readonly, nonatomic) unsigned long length;
		[Export ("length")]
		nuint Length { get; }

		// -(StyleSheet *)item:(unsigned long)index;
		[Export ("item:")]
		StyleSheet Item (nuint index);
	}

	// @protocol DocumentStyle <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface DocumentStyle {

		// @property (retain, nonatomic) StyleSheetList * styleSheets;
		[Export ("styleSheets", ArgumentSemantic.Retain)]
		StyleSheetList StyleSheets { get; set; }
	}

	// @protocol DocumentCSS <DocumentStyle>
	[Protocol, Model]
	interface DocumentCSS : DocumentStyle {

		// @required -(CSSStyleDeclaration *)getOverrideStyle:(Element *)element pseudoElt:(NSString *)pseudoElt;
		[Export ("getOverrideStyle:pseudoElt:")]
		[Abstract]
		CSSStyleDeclaration PseudoElt (Element element, string pseudoElt);
	}

	// @interface SVGPreserveAspectRatio : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGPreserveAspectRatio {

		// @property (nonatomic) SVG_PRESERVEASPECTRATIO align;
		[Export ("align")]
		SVG_PRESERVEASPECTRATIO Align { get; set; }

		// @property (nonatomic) SVG_MEETORSLICE meetOrSlice;
		[Export ("meetOrSlice")]
		SVG_MEETORSLICE MeetOrSlice { get; set; }
	}

	// @interface SVGAnimatedPreserveAspectRatio : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGAnimatedPreserveAspectRatio {

		// @property (retain, nonatomic) SVGPreserveAspectRatio * baseVal;
		[Export ("baseVal", ArgumentSemantic.Retain)]
		SVGPreserveAspectRatio BaseVal { get; set; }

		// @property (readonly, retain, nonatomic) SVGPreserveAspectRatio * animVal;
		[Export ("animVal", ArgumentSemantic.Retain)]
		SVGPreserveAspectRatio AnimVal { get; }
	}

	// @protocol SVGFitToViewBox <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface SVGFitToViewBox {

		// @property (nonatomic) SVGRect viewBox;
		[Export ("viewBox")]
		RectangleF ViewBox { get; set; }

		// @property (retain, nonatomic) SVGAnimatedPreserveAspectRatio * preserveAspectRatio;
		[Export ("preserveAspectRatio", ArgumentSemantic.Retain)]
		SVGAnimatedPreserveAspectRatio PreserveAspectRatio { get; set; }
	}

	// @interface SVGViewSpec : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGViewSpec {

		// @property (readonly, nonatomic) SVGElement * viewTarget;
		[Export ("viewTarget")]
		SVGElement ViewTarget { get; }

		// @property (readonly, nonatomic) NSString * viewBoxString;
		[Export ("viewBoxString")]
		string ViewBoxString { get; }

		// @property (readonly, nonatomic) NSString * preserveAspectRatioString;
		[Export ("preserveAspectRatioString")]
		string PreserveAspectRatioString { get; }

		// @property (readonly, nonatomic) NSString * transformString;
		[Export ("transformString")]
		string TransformString { get; }

		// @property (readonly, nonatomic) NSString * viewTargetString;
		[Export ("viewTargetString")]
		string ViewTargetString { get; }
	}

	// @interface SVGAngle : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGAngle {

		// @property (readonly, nonatomic) SVGKAngleType unitType;
		[Export ("unitType")]
		SVGKAngleType UnitType { get; }

		// @property (nonatomic) float value;
		[Export ("value")]
		float Value { get; set; }

		// @property (nonatomic) float valueInSpecifiedUnits;
		[Export ("valueInSpecifiedUnits")]
		float ValueInSpecifiedUnits { get; set; }

		// @property (retain, nonatomic) NSString * valueAsString;
		[Export ("valueAsString", ArgumentSemantic.Retain)]
		string ValueAsString { get; set; }

		// -(void)newValueSpecifiedUnits:(SVGKAngleType)unitType valueInSpecifiedUnits:(float)valueInSpecifiedUnits;
		[Export ("newValueSpecifiedUnits:valueInSpecifiedUnits:")]
		void NewValueSpecifiedUnits (SVGKAngleType unitType, float valueInSpecifiedUnits);

		// -(void)convertToSpecifiedUnits:(SVGKAngleType)unitType;
		[Export ("convertToSpecifiedUnits:")]
		void ConvertToSpecifiedUnits (SVGKAngleType unitType);
	}

	// @interface SVGMatrix : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGMatrix {

		// @property (nonatomic) float a;
		[Export ("a")]
		float A { get; set; }

		// @property (nonatomic) float b;
		[Export ("b")]
		float B { get; set; }

		// @property (nonatomic) float c;
		[Export ("c")]
		float C { get; set; }

		// @property (nonatomic) float d;
		[Export ("d")]
		float D { get; set; }

		// @property (nonatomic) float e;
		[Export ("e")]
		float E { get; set; }

		// @property (nonatomic) float f;
		[Export ("f")]
		float F { get; set; }

		// -(SVGMatrix *)multiply:(SVGMatrix *)secondMatrix;
		[Export ("multiply:")]
		SVGMatrix Multiply (SVGMatrix secondMatrix);

		// -(SVGMatrix *)inverse;
		[Export ("inverse")]
		SVGMatrix Inverse ();

		// -(SVGMatrix *)translate:(float)x y:(float)y;
		[Export ("translate:y:")]
		SVGMatrix Translate (float x, float y);

		// -(SVGMatrix *)scale:(float)scaleFactor;
		[Export ("scale:")]
		SVGMatrix Scale (float scaleFactor);

		// -(SVGMatrix *)scaleNonUniform:(float)scaleFactorX scaleFactorY:(float)scaleFactorY;
		[Export ("scaleNonUniform:scaleFactorY:")]
		SVGMatrix ScaleNonUniform (float scaleFactorX, float scaleFactorY);

		// -(SVGMatrix *)rotate:(float)angle;
		[Export ("rotate:")]
		SVGMatrix Rotate (float angle);

		// -(SVGMatrix *)rotateFromVector:(float)x y:(float)y;
		[Export ("rotateFromVector:y:")]
		SVGMatrix RotateFromVector (float x, float y);

		// -(SVGMatrix *)flipX;
		[Export ("flipX")]
		SVGMatrix FlipX ();

		// -(SVGMatrix *)flipY;
		[Export ("flipY")]
		SVGMatrix FlipY ();

		// -(SVGMatrix *)skewX:(float)angle;
		[Export ("skewX:")]
		SVGMatrix SkewX (float angle);

		// -(SVGMatrix *)skewY:(float)angle;
		[Export ("skewY:")]
		SVGMatrix SkewY (float angle);
	}

	// @interface SVGPoint : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGPoint {

		// @property (readonly, nonatomic) float x;
		[Export ("x")]
		float X { get; }

		// @property (readonly, nonatomic) float y;
		[Export ("y")]
		float Y { get; }

		// -(SVGPoint *)matrixTransform:(SVGMatrix *)matrix;
		[Export ("matrixTransform:")]
		SVGPoint MatrixTransform (SVGMatrix matrix);
	}

	// @interface SVGTransform : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGTransform {

		// @property (nonatomic) SVGKTransformType type;
		[Export ("type")]
		SVGKTransformType Type { get; set; }

		// @property (retain, nonatomic) SVGMatrix * matrix;
		[Export ("matrix", ArgumentSemantic.Retain)]
		SVGMatrix Matrix { get; set; }

		// @property (readonly, nonatomic) float angle;
		[Export ("angle")]
		float Angle { get; }

		// -(void)setTranslate:(float)tx ty:(float)ty;
		[Export ("setTranslate:ty:")]
		void SetTranslate (float tx, float ty);

		// -(void)setScale:(float)sx sy:(float)sy;
		[Export ("setScale:sy:")]
		void SetScale (float sx, float sy);

		// -(void)setRotate:(float)angle cx:(float)cx cy:(float)cy;
		[Export ("setRotate:cx:cy:")]
		void SetRotate (float angle, float cx, float cy);

		// -(void)setSkewX:(float)angle;
		[Export ("setSkewX:")]
		void SetSkewX (float angle);

		// -(void)setSkewY:(float)angle;
		[Export ("setSkewY:")]
		void SetSkewY (float angle);
	}

	// @interface SVGKSource : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGKSource {

		// -(id)initWithInputSteam:(NSInputStream *)stream;
		[Export ("initWithInputSteam:")]
		IntPtr Constructor (NSInputStream stream);

		// @property (retain, nonatomic) NSString * svgLanguageVersion;
		[Export ("svgLanguageVersion", ArgumentSemantic.Retain)]
		string SvgLanguageVersion { get; set; }

		// @property (retain, nonatomic) NSInputStream * stream;
		[Export ("stream", ArgumentSemantic.Retain)]
		NSInputStream Stream { get; set; }

		// @property (nonatomic) uint64_t approximateLengthInBytesOr0;
		[Export ("approximateLengthInBytesOr0")]
		ulong ApproximateLengthInBytesOr0 { get; set; }

		// -(SVGKSource *)sourceFromRelativePath:(NSString *)path;
		[Export ("sourceFromRelativePath:")]
		SVGKSource SourceFromRelativePath (string path);
	}


	// @interface SVGSVGElement : SVGElement <DocumentCSS, SVGFitToViewBox, ConverterSVGToCALayer>
	[Protocol]
	[BaseType (typeof (SVGElement))]
	interface SVGSVGElement : DocumentCSS, SVGFitToViewBox, ConverterSVGToCALayer {

		// @property (readonly, retain, nonatomic) SVGLength * x;
		[Export ("x", ArgumentSemantic.Retain)]
		SVGLength X { get; }

		// @property (readonly, retain, nonatomic) SVGLength * y;
		[Export ("y", ArgumentSemantic.Retain)]
		SVGLength Y { get; }

		// @property (readonly, retain, nonatomic) SVGLength * width;
		[Export ("width", ArgumentSemantic.Retain)]
		SVGLength Width { get; }

		// @property (readonly, retain, nonatomic) SVGLength * height;
		[Export ("height", ArgumentSemantic.Retain)]
		SVGLength Height { get; }

		// @property (readonly, retain, nonatomic) NSString * contentScriptType;
		[Export ("contentScriptType", ArgumentSemantic.Retain)]
		string ContentScriptType { get; }

		// @property (readonly, retain, nonatomic) NSString * contentStyleType;
		[Export ("contentStyleType", ArgumentSemantic.Retain)]
		string ContentStyleType { get; }

		// @property (readonly, nonatomic) SVGRect viewport;
		[Export ("viewport")]
		RectangleF Viewport { get; }

		// @property (readonly, nonatomic) float pixelUnitToMillimeterX;
		[Export ("pixelUnitToMillimeterX")]
		float PixelUnitToMillimeterX { get; }

		// @property (readonly, nonatomic) float pixelUnitToMillimeterY;
		[Export ("pixelUnitToMillimeterY")]
		float PixelUnitToMillimeterY { get; }

		// @property (readonly, nonatomic) float screenPixelToMillimeterX;
		[Export ("screenPixelToMillimeterX")]
		float ScreenPixelToMillimeterX { get; }

		// @property (readonly, nonatomic) float screenPixelToMillimeterY;
		[Export ("screenPixelToMillimeterY")]
		float ScreenPixelToMillimeterY { get; }

		// @property (readonly, nonatomic) BOOL useCurrentView;
		[Export ("useCurrentView")]
		bool UseCurrentView { get; }

		// @property (readonly, retain, nonatomic) SVGViewSpec * currentView;
		[Export ("currentView", ArgumentSemantic.Retain)]
		SVGViewSpec CurrentView { get; }

		// @property (readonly, nonatomic) float currentScale;
		[Export ("currentScale")]
		float CurrentScale { get; }

		// @property (readonly, retain, nonatomic) SVGPoint * currentTranslate;
		[Export ("currentTranslate", ArgumentSemantic.Retain)]
		SVGPoint CurrentTranslate { get; }

		// @property (readwrite, retain, nonatomic) SVGKSource * source;
		[Export ("source", ArgumentSemantic.Retain)]
		SVGKSource Source { get; set; }

		// @property (readonly, nonatomic) SVGRect requestedViewport;
		[Export ("requestedViewport")]
		RectangleF RequestedViewport { get; }

		// @property (readonly) double aspectRatioFromWidthPerHeight;
		[Export ("aspectRatioFromWidthPerHeight")]
		double AspectRatioFromWidthPerHeight { get; }

		// @property (readonly) double aspectRatioFromViewBox;
		[Export ("aspectRatioFromViewBox")]
		double AspectRatioFromViewBox { get; }

		// -(long)suspendRedraw:(long)maxWaitMilliseconds;
		[Export ("suspendRedraw:")]
		nint SuspendRedraw (nint maxWaitMilliseconds);

		// -(void)unsuspendRedraw:(long)suspendHandleID;
		[Export ("unsuspendRedraw:")]
		void UnsuspendRedraw (nint suspendHandleID);

		// -(void)unsuspendRedrawAll;
		[Export ("unsuspendRedrawAll")]
		void UnsuspendRedrawAll ();

		// -(void)forceRedraw;
		[Export ("forceRedraw")]
		void ForceRedraw ();

		// -(void)pauseAnimations;
		[Export ("pauseAnimations")]
		void PauseAnimations ();

		// -(void)unpauseAnimations;
		[Export ("unpauseAnimations")]
		void UnpauseAnimations ();

		// -(BOOL)animationsPaused;
		[Export ("animationsPaused")]
		bool AnimationsPaused ();

		// -(float)getCurrentTime;
		[Export ("getCurrentTime")]
		float GetCurrentTime ();

		// -(void)setCurrentTime:(float)seconds;
		[Export ("setCurrentTime:")]
		void SetCurrentTime (float seconds);

		// -(NodeList *)getIntersectionList:(SVGRect)rect referenceElement:(SVGElement *)referenceElement;
		[Export ("getIntersectionList:referenceElement:")]
		NodeList GetIntersectionList (RectangleF rect, SVGElement referenceElement);

		// -(NodeList *)getEnclosureList:(SVGRect)rect referenceElement:(SVGElement *)referenceElement;
		[Export ("getEnclosureList:referenceElement:")]
		NodeList GetEnclosureList (RectangleF rect, SVGElement referenceElement);

		// -(BOOL)checkIntersection:(SVGElement *)element rect:(SVGRect)rect;
		[Export ("checkIntersection:rect:")]
		bool CheckIntersection (SVGRectElement element, RectangleF rect);

		// -(BOOL)checkEnclosure:(SVGElement *)element rect:(SVGRect)rect;
		[Export ("checkEnclosure:rect:")]
		bool CheckEnclosure (SVGRectElement element, RectangleF rect);

		// -(void)deselectAll;
		[Export ("deselectAll")]
		void DeselectAll ();

//		// -(SVGNumber)createSVGNumber;
//		[Export ("createSVGNumber")]
//		SVGNumber CreateSVGNumber ();

		// -(SVGLength *)createSVGLength;
		[Export ("createSVGLength")]
		SVGLength CreateSVGLength ();

		// -(SVGAngle *)createSVGAngle;
		[Export ("createSVGAngle")]
		SVGAngle CreateSVGAngle ();

		// -(SVGPoint *)createSVGPoint;
		[Export ("createSVGPoint")]
		SVGPoint CreateSVGPoint ();

		// -(SVGMatrix *)createSVGMatrix;
		[Export ("createSVGMatrix")]
		SVGMatrix CreateSVGMatrix ();

		// -(SVGRect)createSVGRect;
		[Export ("createSVGRect")]
		RectangleF CreateSVGRect ();

		// -(SVGTransform *)createSVGTransform;
		[Export ("createSVGTransform")]
		SVGTransform CreateSVGTransform ();

		// -(SVGTransform *)createSVGTransformFromMatrix:(SVGMatrix *)matrix;
		[Export ("createSVGTransformFromMatrix:")]
		SVGTransform CreateSVGTransformFromMatrix (SVGMatrix matrix);

		// -(Element *)getElementById:(NSString *)elementId;
		[Export ("getElementById:")]
		Element GetElementById (string elementId);

		// -(SVGElement *)findFirstElementOfClass:(Class)classParameter;
		[Export ("findFirstElementOfClass:")]
		SVGElement FindFirstElementOfClass (Class classParameter);
	}

	// @interface CharacterData : Node
	[Protocol]
	[BaseType (typeof (Node))]
	interface CharacterData {

		// @property (readonly, retain, nonatomic) NSString * data;
		[Export ("data", ArgumentSemantic.Retain)]
		string Data { get; }

		// @property (readonly, nonatomic) unsigned long length;
		[Export ("length")]
		nuint Length { get; }

		// -(NSString *)substringData:(unsigned long)offset count:(unsigned long)count;
		[Export ("substringData:count:")]
		string SubstringData (nuint offset, nuint count);

		// -(void)appendData:(NSString *)arg;
		[Export ("appendData:")]
		void AppendData (string arg);

		// -(void)insertData:(unsigned long)offset arg:(NSString *)arg;
		[Export ("insertData:arg:")]
		void InsertData (nuint offset, string arg);

		// -(void)deleteData:(unsigned long)offset count:(unsigned long)count;
		[Export ("deleteData:count:")]
		void DeleteData (nuint offset, nuint count);

		// -(void)replaceData:(unsigned long)offset count:(unsigned long)count arg:(NSString *)arg;
		[Export ("replaceData:count:arg:")]
		void ReplaceData (nuint offset, nuint count, string arg);
	}

	// @interface Comment : CharacterData
	[Protocol]
	[BaseType (typeof (CharacterData))]
	interface Comment {

		// -(id)initWithValue:(NSString *)v;
		[Export ("initWithValue:")]
		IntPtr Constructor (string v);
	}

	// @interface Text : CharacterData
	[Protocol]
	[BaseType (typeof (CharacterData))]
	interface Text {

		// -(id)initWithValue:(NSString *)v;
		[Export ("initWithValue:")]
		IntPtr Constructor (string v);

		// -(Text *)splitText:(unsigned long)offset;
		[Export ("splitText:")]
		Text SplitText (nuint offset);
	}

	// @interface CDATASection : Text
	[Protocol]
	[BaseType (typeof (Text))]
	interface CDATASection {

		// -(id)initWithValue:(NSString *)v;
		[Export ("initWithValue:")]
		IntPtr Constructor (string v);
	}

	// @interface DocumentFragment : Node
	[Protocol]
	[BaseType (typeof (Node))]
	interface DocumentFragment {

	}

	// @interface EntityReference : Node
	[Protocol]
	[BaseType (typeof (Node))]
	interface EntityReference {

	}

	// @interface ProcessingInstruction : Node
	[Protocol]
	[BaseType (typeof (Node))]
	interface ProcessingInstruction {

		// -(id)initProcessingInstruction:(NSString *)target value:(NSString *)data;
		[Export ("initProcessingInstruction:value:")]
		IntPtr Constructor (string target, string data);

		// @property (readonly, retain, nonatomic) NSString * target;
		[Export ("target", ArgumentSemantic.Retain)]
		string Target { get; }

		// @property (readonly, retain, nonatomic) NSString * data;
		[Export ("data", ArgumentSemantic.Retain)]
		string Data { get; }
	}

	// @interface NamedNodeMap : NSObject <NSCopying>
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface NamedNodeMap {

		// @property (readonly) unsigned long length;
		[Export ("length")]
		nuint Length { get; }

		// -(Node *)getNamedItem:(NSString *)name;
		[Export ("getNamedItem:")]
		Node GetNamedItem (string name);

		// -(Node *)setNamedItem:(Node *)arg;
		[Export ("setNamedItem:")]
		Node SetNamedItem (Node arg);

		// -(Node *)removeNamedItem:(NSString *)name;
		[Export ("removeNamedItem:")]
		Node RemoveNamedItem (string name);

		// -(Node *)item:(unsigned long)index;
		[Export ("item:")]
		Node Item (nuint index);

		// -(Node *)getNamedItemNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("getNamedItemNS:localName:")]
		Node GetNamedItemNS (string namespaceURI, string localName);

		// -(Node *)setNamedItemNS:(Node *)arg;
		[Export ("setNamedItemNS:")]
		Node SetNamedItemNS (Node arg);

		// -(Node *)removeNamedItemNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("removeNamedItemNS:localName:")]
		Node RemoveNamedItemNS (string namespaceURI, string localName);

		// -(Node *)setNamedItemNS:(Node *)arg inNodeNamespace:(NSString *)nodesNamespace;
		[Export ("setNamedItemNS:inNodeNamespace:")]
		Node SetNamedItemNS (Node arg, string nodesNamespace);
	}

	// @interface DocumentType : Node
	[Protocol]
	[BaseType (typeof (Node))]
	interface DocumentType {

		// @property (readonly, retain, nonatomic) NSString * name;
		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; }

		// @property (readonly, retain, nonatomic) NamedNodeMap * entities;
		[Export ("entities", ArgumentSemantic.Retain)]
		NamedNodeMap Entities { get; }

		// @property (readonly, retain, nonatomic) NamedNodeMap * notations;
		[Export ("notations", ArgumentSemantic.Retain)]
		NamedNodeMap Notations { get; }

		// @property (readonly, retain, nonatomic) NSString * publicId;
		[Export ("publicId", ArgumentSemantic.Retain)]
		string PublicId { get; }

		// @property (readonly, retain, nonatomic) NSString * systemId;
		[Export ("systemId", ArgumentSemantic.Retain)]
		string SystemId { get; }

		// @property (readonly, retain, nonatomic) NSString * internalSubset;
		[Export ("internalSubset", ArgumentSemantic.Retain)]
		string InternalSubset { get; }
	}

	// @interface AppleSucksDOMImplementation : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface AppleSucksDOMImplementation {

		// -(BOOL)hasFeature:(NSString *)feature version:(NSString *)version;
		[Export ("hasFeature:version:")]
		bool HasFeature (string feature, string version);

		// -(DocumentType *)createDocumentType:(NSString *)qualifiedName publicId:(NSString *)publicId systemId:(NSString *)systemId;
		[Export ("createDocumentType:publicId:systemId:")]
		DocumentType CreateDocumentType (string qualifiedName, string publicId, string systemId);

		// -(Document *)createDocument:(NSString *)namespaceURI qualifiedName:(NSString *)qualifiedName doctype:(DocumentType *)doctype;
		[Export ("createDocument:qualifiedName:doctype:")]
		Document CreateDocument (string namespaceURI, string qualifiedName, DocumentType doctype);
	}

	// @interface Document : Node
	[Protocol]
	[BaseType (typeof (Node))]
	interface Document {

		// @property (readonly, retain, nonatomic) DocumentType * doctype;
		[Export ("doctype", ArgumentSemantic.Retain)]
		DocumentType Doctype { get; }

		// @property (readonly, retain, nonatomic) AppleSucksDOMImplementation * implementation;
		[Export ("implementation", ArgumentSemantic.Retain)]
		AppleSucksDOMImplementation Implementation { get; }

		// @property (readonly, retain, nonatomic) Element * documentElement;
		[Export ("documentElement", ArgumentSemantic.Retain)]
		Element DocumentElement { get; }

		// -(Element *)createElement:(NSString *)tagName;
		[Export ("createElement:")]
		Element CreateElement (string tagName);

		// -(DocumentFragment *)createDocumentFragment;
		[Export ("createDocumentFragment")]
		DocumentFragment CreateDocumentFragment ();

		// -(Text *)createTextNode:(NSString *)data;
		[Export ("createTextNode:")]
		Text CreateTextNode (string data);

		// -(Comment *)createComment:(NSString *)data;
		[Export ("createComment:")]
		Comment CreateComment (string data);

		// -(CDATASection *)createCDATASection:(NSString *)data;
		[Export ("createCDATASection:")]
		CDATASection CreateCDATASection (string data);

		// -(ProcessingInstruction *)createProcessingInstruction:(NSString *)target data:(NSString *)data;
		[Export ("createProcessingInstruction:data:")]
		ProcessingInstruction CreateProcessingInstruction (string target, string data);

		// -(Attr *)createAttribute:(NSString *)data;
		[Export ("createAttribute:")]
		Attr CreateAttribute (string data);

		// -(EntityReference *)createEntityReference:(NSString *)data;
		[Export ("createEntityReference:")]
		EntityReference CreateEntityReference (string data);

		// -(NodeList *)getElementsByTagName:(NSString *)data;
		[Export ("getElementsByTagName:")]
		NodeList GetElementsByTagName (string data);

		// -(Node *)importNode:(Node *)importedNode deep:(BOOL)deep;
		[Export ("importNode:deep:")]
		Node ImportNode (Node importedNode, bool deep);

		// -(Element *)createElementNS:(NSString *)namespaceURI qualifiedName:(NSString *)qualifiedName;
		[Export ("createElementNS:qualifiedName:")]
		Element CreateElementNS (string namespaceURI, string qualifiedName);

		// -(Attr *)createAttributeNS:(NSString *)namespaceURI qualifiedName:(NSString *)qualifiedName;
		[Export ("createAttributeNS:qualifiedName:")]
		Attr CreateAttributeNS (string namespaceURI, string qualifiedName);

		// -(NodeList *)getElementsByTagNameNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("getElementsByTagNameNS:localName:")]
		NodeList GetElementsByTagNameNS (string namespaceURI, string localName);

		// -(Element *)getElementById:(NSString *)elementId;
		[Export ("getElementById:")]
		Element GetElementById (string elementId);
	}

	// @interface SVGDocument : Document
	[Protocol]
	[BaseType (typeof (Document))]
	interface SVGDocument {

		// @property (readonly, retain, nonatomic) NSString * title;
		[Export ("title", ArgumentSemantic.Retain)]
		string Title { get; }

		// @property (readonly, retain, nonatomic) NSString * referrer;
		[Export ("referrer", ArgumentSemantic.Retain)]
		string Referrer { get; }

		// @property (readonly, retain, nonatomic) NSString * domain;
		[Export ("domain", ArgumentSemantic.Retain)]
		string Domain { get; }

		// @property (readonly, retain, nonatomic) NSString * URL;
		[Export ("URL", ArgumentSemantic.Retain)]
		string URL { get; }

		// @property (readonly, retain, nonatomic) SVGSVGElement * rootElement;
		[Export ("rootElement", ArgumentSemantic.Retain)]
		SVGSVGElement RootElement { get; }

		// -(NSMutableDictionary *)allPrefixesByNamespace;
		[Export ("allPrefixesByNamespace")]
		NSMutableDictionary AllPrefixesByNamespace ();

		// -(NSMutableDictionary *)allPrefixesByNamespaceNormalized;
		[Export ("allPrefixesByNamespaceNormalized")]
		NSMutableDictionary AllPrefixesByNamespaceNormalized ();
	}

	// @protocol SVGKParserExtension <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface SVGKParserExtension {

		// @required -(NSArray *)supportedNamespaces;
		[Export ("supportedNamespaces")]
		[Abstract]
		NSObject [] SupportedNamespaces ();

		// @required -(NSArray *)supportedTags;
		[Export ("supportedTags")]
		[Abstract]
		NSObject [] SupportedTags ();

		// @required -(Node *)handleStartElement:(NSString *)name document:(SVGKSource *)document namePrefix:(NSString *)prefix namespaceURI:(NSString *)XMLNSURI attributes:(NSMutableDictionary *)attributes parseResult:(SVGKParseResult *)parseResult parentNode:(Node *)parentNode;
		[Export ("handleStartElement:document:namePrefix:namespaceURI:attributes:parseResult:parentNode:")]
		[Abstract]
		Node HandleStartElement (string name, SVGKSource document, string prefix, string XMLNSURI, NSMutableDictionary attributes, SVGKParseResult parseResult, Node parentNode);

		// @required -(void)handleEndElement:(Node *)newNode document:(SVGKSource *)document parseResult:(SVGKParseResult *)parseResult;
		[Export ("handleEndElement:document:parseResult:")]
		[Abstract]
		void HandleEndElement (Node newNode, SVGKSource document, SVGKParseResult parseResult);
	}

	// @interface SVGKParseResult : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGKParseResult {

		// @property (retain, nonatomic) NSMutableArray * warnings;
		[Export ("warnings", ArgumentSemantic.Retain)]
		NSMutableArray Warnings { get; set; }

		// @property (retain, nonatomic) NSMutableArray * errorsRecoverable;
		[Export ("errorsRecoverable", ArgumentSemantic.Retain)]
		NSMutableArray ErrorsRecoverable { get; set; }

		// @property (retain, nonatomic) NSMutableArray * errorsFatal;
		[Export ("errorsFatal", ArgumentSemantic.Retain)]
		NSMutableArray ErrorsFatal { get; set; }

		// @property (nonatomic) BOOL libXMLFailed;
		[Export ("libXMLFailed")]
		bool LibXMLFailed { get; set; }

		// @property (nonatomic) double parseProgressFractionApproximate;
		[Export ("parseProgressFractionApproximate")]
		double ParseProgressFractionApproximate { get; set; }

		// @property (retain, nonatomic) SVGSVGElement * rootOfSVGTree;
		[Export ("rootOfSVGTree", ArgumentSemantic.Retain)]
		SVGSVGElement RootOfSVGTree { get; set; }

		// @property (retain, nonatomic) SVGDocument * parsedDocument;
		[Export ("parsedDocument", ArgumentSemantic.Retain)]
		SVGDocument ParsedDocument { get; set; }

		// @property (retain, nonatomic) NSMutableDictionary * namespacesEncountered;
		[Export ("namespacesEncountered", ArgumentSemantic.Retain)]
		NSMutableDictionary NamespacesEncountered { get; set; }

		// -(void)addSourceError:(NSError *)fatalError;
		[Export ("addSourceError:")]
		void AddSourceError (NSError fatalError);

		// -(void)addParseWarning:(NSError *)warning;
		[Export ("addParseWarning:")]
		void AddParseWarning (NSError warning);

		// -(void)addParseErrorRecoverable:(NSError *)recoverableError;
		[Export ("addParseErrorRecoverable:")]
		void AddParseErrorRecoverable (NSError recoverableError);

		// -(void)addParseErrorFatal:(NSError *)fatalError;
		[Export ("addParseErrorFatal:")]
		void AddParseErrorFatal (NSError fatalError);

		// -(void)addSAXError:(NSError *)saxError;
		[Export ("addSAXError:")]
		void AddSAXError (NSError saxError);
	}

	// @interface SVGClipPathElement : SVGElement <SVGTransformable, SVGStylable>
	[Protocol]
	[BaseType (typeof (SVGElement))]
	interface SVGClipPathElement : SVGTransformable, SVGStylable {

		// @property (readonly, nonatomic) SVG_UNIT_TYPE clipPathUnits;
		[Export ("clipPathUnits")]
		SVG_UNIT_TYPE ClipPathUnits { get; }

		// -(CALayer *)newLayer;
		[Export ("newLayer")]
		CALayer NewLayer ();

		// -(void)layoutLayer:(CALayer *)layer toMaskLayer:(CALayer *)maskThis;
		[Export ("layoutLayer:toMaskLayer:")]
		void LayoutLayer (CALayer layer, CALayer maskThis);
	}

	// @interface SVGDefsElement : SVGElement
	[Protocol]
	[BaseType (typeof (SVGElement))]
	interface SVGDefsElement {

	}

	// @interface SVGDescriptionElement : SVGElement
	[Protocol]
	[BaseType (typeof (SVGElement))]
	interface SVGDescriptionElement {

	}

	// @interface SVGKParser : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGKParser {

		// -(id)initWithSource:(SVGKSource *)doc;
		[Export ("initWithSource:")]
		IntPtr Constructor (SVGKSource doc);

		// @property (readonly, retain, nonatomic) SVGKSource * source;
		[Export ("source", ArgumentSemantic.Retain)]
		SVGKSource Source { get; }

		// @property (readonly, retain, nonatomic) NSMutableArray * externalStylesheets;
		[Export ("externalStylesheets", ArgumentSemantic.Retain)]
		NSMutableArray ExternalStylesheets { get; }

		// @property (readonly, retain, nonatomic) SVGKParseResult * currentParseRun;
		[Export ("currentParseRun", ArgumentSemantic.Retain)]
		SVGKParseResult CurrentParseRun { get; }

		// @property (retain, nonatomic) NSMutableArray * parserExtensions;
		[Export ("parserExtensions", ArgumentSemantic.Retain)]
		NSMutableArray ParserExtensions { get; set; }

		// @property (retain, nonatomic) NSMutableDictionary * parserKnownNamespaces;
		[Export ("parserKnownNamespaces", ArgumentSemantic.Retain)]
		NSMutableDictionary ParserKnownNamespaces { get; set; }

		// +(void)cancelParser:(SVGKParser *)parserToCancel;
		[Static, Export ("cancelParser:")]
		void CancelParser (SVGKParser parserToCancel);

		// +(SVGKParser *)newParserWithDefaultSVGKParserExtensions:(SVGKSource *)source;
		[Static, Export ("newParserWithDefaultSVGKParserExtensions:")]
		SVGKParser NewParserWithDefaultSVGKParserExtensions (SVGKSource source);

		// +(SVGKParseResult *)parseSourceUsingDefaultSVGKParser:(SVGKSource *)source;
		[Static, Export ("parseSourceUsingDefaultSVGKParser:")]
		SVGKParseResult ParseSourceUsingDefaultSVGKParser (SVGKSource source);

		// -(SVGKParseResult *)parseSynchronously;
		[Export ("parseSynchronously")]
		SVGKParseResult ParseSynchronously ();

		// +(NSDictionary *)NSDictionaryFromCSSAttributes:(Attr *)styleAttribute;
		[Static, Export ("NSDictionaryFromCSSAttributes:")]
		NSDictionary NSDictionaryFromCSSAttributes (Attr styleAttribute);

		// -(void)addDefaultSVGParserExtensions;
		[Export ("addDefaultSVGParserExtensions")]
		void AddDefaultSVGParserExtensions ();

		// -(void)addParserExtension:(NSObject<SVGKParserExtension> *)extension;
		[Export ("addParserExtension:")]
		void AddParserExtension (NSObject extension);
	}

	// @interface SVGKImage : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGKImage {

		// -(id)initWithContentsOfFile:(NSString *)path;
		[Export ("initWithContentsOfFile:")]
		IntPtr Constructor (string path);

		// -(id)initWithData:(NSData *)data;
		[Export ("initWithData:")]
		IntPtr Constructor (NSData data);

		// -(id)initWithSource:(SVGKSource *)source;
		[Export ("initWithSource:")]
		IntPtr Constructor (SVGKSource source);

		// -(id)initWithParsedSVG:(SVGKParseResult *)parseResult fromSource:(SVGKSource *)parseSource;
		[Export ("initWithParsedSVG:fromSource:")]
		IntPtr Constructor (SVGKParseResult parseResult, SVGKSource parseSource);

		// @property (readonly, nonatomic) UIImage * UIImage;
		[Export ("UIImage")]
		UIImage UIImage { get; }

		// @property (readonly, retain, nonatomic) SVGKSource * source;
		[Export ("source", ArgumentSemantic.Retain)]
		SVGKSource Source { get; }

		// @property (readonly, retain, nonatomic) SVGKParseResult * parseErrorsAndWarnings;
		[Export ("parseErrorsAndWarnings", ArgumentSemantic.Retain)]
		SVGKParseResult ParseErrorsAndWarnings { get; }

		// @property (readonly, retain, nonatomic) SVGDocument * DOMDocument;
		[Export ("DOMDocument", ArgumentSemantic.Retain)]
		SVGDocument DOMDocument { get; }

		// @property (readonly, retain, nonatomic) SVGSVGElement * DOMTree;
		[Export ("DOMTree", ArgumentSemantic.Retain)]
		SVGSVGElement DOMTree { get; }

		// @property (readonly, retain, nonatomic) CALayer * CALayerTree;
		[Export ("CALayerTree", ArgumentSemantic.Retain)]
		CALayer CALayerTree { get; }

		// @property (readonly, retain, nonatomic) NSString * nameUsedToInstantiate;
		[Export ("nameUsedToInstantiate", ArgumentSemantic.Retain)]
		string NameUsedToInstantiate { get; }

		// @property (nonatomic) CGSize size;
		[Export ("size")]
		CGSize Size { get; set; }

		// @property (nonatomic) CGFloat scale;
		[Export ("scale")]
		nfloat Scale { get; set; }

		// +(SVGKImage *)imageNamed:(NSString *)name;
		[Static, Export ("imageNamed:")]
		SVGKImage ImageNamed (string name);

		// +(SVGKParser *)imageAsynchronouslyNamed:(NSString *)name onCompletion:(SVGKImageAsynchronousLoadingDelegate)blockCompleted;
		[Static, Export ("imageAsynchronouslyNamed:onCompletion:")]
		SVGKParser ImageAsynchronouslyNamed (string name, Action<SVGKImage> blockCompleted);

		// +(SVGKImage *)imageWithContentsOfFile:(NSString *)path;
		[Static, Export ("imageWithContentsOfFile:")]
		SVGKImage ImageWithContentsOfFile (string path);

		// +(SVGKImage *)imageWithSource:(SVGKSource *)newSource;
		[Static, Export ("imageWithSource:")]
		SVGKImage ImageWithSource (SVGKSource newSource);

		// -(BOOL)hasSize;
		[Export ("hasSize")]
		bool HasSize ();

		// -(void)drawAtPoint:(CGPoint)point;
		[Export ("drawAtPoint:")]
		void DrawAtPoint (CGPoint point);

		// -(void)drawAtPoint:(CGPoint)point blendMode:(CGBlendMode)blendMode alpha:(CGFloat)alpha;
		[Export ("drawAtPoint:blendMode:alpha:")]
		void DrawAtPoint (CGPoint point, CGBlendMode blendMode, nfloat alpha);

		// -(void)drawInRect:(CGRect)rect;
		[Export ("drawInRect:")]
		void DrawInRect (CGRect rect);

		// -(void)drawInRect:(CGRect)rect blendMode:(CGBlendMode)blendMode alpha:(CGFloat)alpha;
		[Export ("drawInRect:blendMode:alpha:")]
		void DrawInRect (CGRect rect, CGBlendMode blendMode, nfloat alpha);

		// -(void)drawAsPatternInRect:(CGRect)rect;
		[Export ("drawAsPatternInRect:")]
		void DrawAsPatternInRect (CGRect rect);

		// +(UIImage *)animatedImageNamed:(NSString *)name duration:(NSTimeInterval)duration;
		[Static, Export ("animatedImageNamed:duration:")]
		UIImage AnimatedImageNamed (string name, double duration);

		// +(UIImage *)animatedResizableImageNamed:(NSString *)name capInsets:(UIEdgeInsets)capInsets duration:(NSTimeInterval)duration;
		[Static, Export ("animatedResizableImageNamed:capInsets:duration:")]
		UIImage AnimatedResizableImageNamed (string name, UIEdgeInsets capInsets, double duration);

		// +(UIImage *)animatedImageWithImages:(NSArray *)images duration:(NSTimeInterval)duration;
		[Static, Export ("animatedImageWithImages:duration:")]
		UIImage AnimatedImageWithImages (NSObject [] images, double duration);

		// +(SVGKImage *)imageWithContentsOfURL:(NSURL *)url;
		[Static, Export ("imageWithContentsOfURL:")]
		SVGKImage ImageWithContentsOfURL (NSUrl url);

		// -(CALayer *)newCALayerTree;
		[Export ("newCALayerTree")]
		CALayer NewCALayerTree ();

		// -(CALayer *)layerWithIdentifier:(NSString *)identifier;
		[Export ("layerWithIdentifier:")]
		CALayer LayerWithIdentifier (string identifier);

		// -(CALayer *)layerWithIdentifier:(NSString *)identifier layer:(CALayer *)layer;
		[Export ("layerWithIdentifier:layer:")]
		CALayer LayerWithIdentifier (string identifier, CALayer layer);

		// -(CALayer *)newCopyPositionedAbsoluteLayerWithIdentifier:(NSString *)identifier;
		[Export ("newCopyPositionedAbsoluteLayerWithIdentifier:")]
		CALayer NewCopyPositionedAbsoluteLayerWithIdentifier (string identifier);

		// -(CALayer *)newCopyPositionedAbsoluteOfLayer:(CALayer *)originalLayer;
		[Export ("newCopyPositionedAbsoluteOfLayer:")]
		CALayer NewCopyPositionedAbsoluteOfLayer (CALayer originalLayer);

		// -(CALayer *)newCopyPositionedAbsoluteOfLayer:(CALayer *)originalLayer withSubLayers:(BOOL)recursive;
		[Export ("newCopyPositionedAbsoluteOfLayer:withSubLayers:")]
		CALayer NewCopyPositionedAbsoluteOfLayer (CALayer originalLayer, bool recursive);

		// -(NSDictionary *)dictionaryOfLayers;
		[Export ("dictionaryOfLayers")]
		NSDictionary DictionaryOfLayers ();

		// -(void)scaleToFitInside:(CGSize)maxSize;
		[Export ("scaleToFitInside:")]
		void ScaleToFitInside (CGSize maxSize);
	}

	// @interface SVGGElement : SVGElement <SVGTransformable, SVGStylable, ConverterSVGToCALayer>
	[Protocol]
	[BaseType (typeof (SVGElement))]
	interface SVGGElement : SVGTransformable, SVGStylable, ConverterSVGToCALayer {

	}

	// @interface SVGImageElement : SVGElement <SVGTransformable, SVGStylable, ConverterSVGToCALayer, SVGFitToViewBox>
	[Protocol]
	[BaseType (typeof (SVGElement))]
	interface SVGImageElement : SVGTransformable, SVGStylable, ConverterSVGToCALayer, SVGFitToViewBox {

		// @property (readonly, nonatomic) CGFloat x;
		[Export ("x")]
		nfloat X { get; }

		// @property (readonly, nonatomic) CGFloat y;
		[Export ("y")]
		nfloat Y { get; }

		// @property (readonly, nonatomic) CGFloat width;
		[Export ("width")]
		nfloat Width { get; }

		// @property (readonly, nonatomic) CGFloat height;
		[Export ("height")]
		nfloat Height { get; }

		// @property (readonly, retain, nonatomic) NSString * href;
		[Export ("href", ArgumentSemantic.Retain)]
		string Href { get; }
	}

	// @interface SVGLineElement : BaseClassForAllSVGBasicShapes
	[Protocol]
	[BaseType (typeof (BaseClassForAllSVGBasicShapes))]
	interface SVGLineElement {

		// @property (readonly, nonatomic) CGFloat x1;
		[Export ("x1")]
		nfloat X1 { get; }

		// @property (readonly, nonatomic) CGFloat y1;
		[Export ("y1")]
		nfloat Y1 { get; }

		// @property (readonly, nonatomic) CGFloat x2;
		[Export ("x2")]
		nfloat X2 { get; }

		// @property (readonly, nonatomic) CGFloat y2;
		[Export ("y2")]
		nfloat Y2 { get; }
	}

	// @interface SVGPathElement : BaseClassForAllSVGBasicShapes
	[Protocol]
	[BaseType (typeof (BaseClassForAllSVGBasicShapes))]
	interface SVGPathElement {

	}

	// @interface SVGPolygonElement : BaseClassForAllSVGBasicShapes
	[Protocol]
	[BaseType (typeof (BaseClassForAllSVGBasicShapes))]
	interface SVGPolygonElement {

	}

	// @interface SVGPolylineElement : BaseClassForAllSVGBasicShapes
	[Protocol]
	[BaseType (typeof (BaseClassForAllSVGBasicShapes))]
	interface SVGPolylineElement {

	}

	// @interface SVGRectElement : BaseClassForAllSVGBasicShapes <SVGStylable, SVGTransformable>
	[Protocol]
	[BaseType (typeof (BaseClassForAllSVGBasicShapes))]
	interface SVGRectElement : SVGStylable, SVGTransformable {

		// @property (readonly, retain, nonatomic) SVGLength * x;
		[Export ("x", ArgumentSemantic.Retain)]
		SVGLength X { get; }

		// @property (readonly, retain, nonatomic) SVGLength * y;
		[Export ("y", ArgumentSemantic.Retain)]
		SVGLength Y { get; }

		// @property (readonly, retain, nonatomic) SVGLength * width;
		[Export ("width", ArgumentSemantic.Retain)]
		SVGLength Width { get; }

		// @property (readonly, retain, nonatomic) SVGLength * height;
		[Export ("height", ArgumentSemantic.Retain)]
		SVGLength Height { get; }

		// @property (readonly, retain, nonatomic) SVGLength * rx;
		[Export ("rx", ArgumentSemantic.Retain)]
		SVGLength Rx { get; }

		// @property (readonly, retain, nonatomic) SVGLength * ry;
		[Export ("ry", ArgumentSemantic.Retain)]
		SVGLength Ry { get; }
	}

	// @interface SVGTitleElement : SVGElement
	[Protocol]
	[BaseType (typeof (SVGElement))]
	interface SVGTitleElement {

	}

	// @interface SVGKPattern : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGKPattern {

		// @property (readwrite, retain, nonatomic) UIColor * color;
		[Export ("color", ArgumentSemantic.Retain)]
		UIColor Color { get; set; }

		// +(SVGKPattern *)patternWithUIColor:(UIColor *)color;
		[Static, Export ("patternWithUIColor:")]
		SVGKPattern PatternWithUIColor (UIColor color);

		// +(SVGKPattern *)patternWithImage:(UIImage *)image;
		[Static, Export ("patternWithImage:")]
		SVGKPattern PatternWithImage (UIImage image);

		// -(CGColorRef)CGColor;
		[Export ("CGColor")]
		CGColor CGColor ();
	}

	// @interface SVGKImageView : UIView
	[Protocol]
	[BaseType (typeof (UIView))]
	interface SVGKImageView {

		// -(id)initWithSVGKImage:(SVGKImage *)im;
		[Export ("initWithSVGKImage:")]
		IntPtr Constructor (SVGKImage im);

		// @property (retain, nonatomic) SVGKImage * image;
		[Export ("image", ArgumentSemantic.Retain)]
		SVGKImage Image { get; set; }

		// @property (nonatomic) BOOL showBorder;
		[Export ("showBorder")]
		bool ShowBorder { get; set; }

		// @property (readonly, nonatomic) NSTimeInterval timeIntervalForLastReRenderOfSVGFromMemory;
		[Export ("timeIntervalForLastReRenderOfSVGFromMemory")]
		double TimeIntervalForLastReRenderOfSVGFromMemory { get; }
	}

	// @interface SVGKFastImageView : SVGKImageView
	[Protocol]
	[BaseType (typeof (SVGKImageView))]
	interface SVGKFastImageView {

		// -(id)initWithSVGKImage:(SVGKImage *)im;
		[Export ("initWithSVGKImage:")]
		IntPtr Constructor (SVGKImage im);

		// @property (nonatomic) CGSize tileRatio;
		[Export ("tileRatio")]
		CGSize TileRatio { get; set; }

		// @property (nonatomic) BOOL disableAutoRedrawAtHighestResolution;
		[Export ("disableAutoRedrawAtHighestResolution")]
		bool DisableAutoRedrawAtHighestResolution { get; set; }

		// +(BOOL)svgImageHasNoGradients:(SVGKImage *)image;
		[Static, Export ("svgImageHasNoGradients:")]
		bool SvgImageHasNoGradients (SVGKImage image);

		// +(BOOL)svgElementAndDescendentsHaveNoGradients:(SVGElement *)element;
		[Static, Export ("svgElementAndDescendentsHaveNoGradients:")]
		bool SvgElementAndDescendentsHaveNoGradients (SVGElement element);
	}

	// @interface SVGKLayeredImageView : SVGKImageView
	[Protocol]
	[BaseType (typeof (SVGKImageView))]
	interface SVGKLayeredImageView {

	}

	// @interface SVGKLayer : CALayer
	[Protocol]
	[BaseType (typeof (CALayer))]
	interface SVGKLayer {

		// @property (retain, nonatomic) SVGKImage * SVGImage;
		[Export ("SVGImage", ArgumentSemantic.Retain)]
		SVGKImage SVGImage { get; set; }

		// @property (nonatomic) BOOL showBorder;
		[Export ("showBorder")]
		bool ShowBorder { get; set; }

		// @property (retain, nonatomic) NSDate * startRenderTime;
		[Export ("startRenderTime", ArgumentSemantic.Retain)]
		NSDate StartRenderTime { get; set; }

		// @property (retain, nonatomic) NSDate * endRenderTime;
		[Export ("endRenderTime", ArgumentSemantic.Retain)]
		NSDate EndRenderTime { get; set; }
	}

	// @interface SVGTextContentElement : SVGElement <SVGStylable>
	[Protocol,]
	[BaseType (typeof (SVGElement))]
	interface SVGTextContentElement : SVGStylable {

		// @property (readonly, nonatomic) SVGLength * textLength;
		[Export ("textLength")]
		SVGLength TextLength { get; }
	}

	// @interface SVGTextPositioningElement : SVGTextContentElement
	[Protocol]
	[BaseType (typeof (SVGTextContentElement))]
	interface SVGTextPositioningElement {

		// @property (readonly, retain, nonatomic) SVGLength * x;
		[Export ("x", ArgumentSemantic.Retain)]
		SVGLength X { get; }

		// @property (readonly, retain, nonatomic) SVGLength * y;
		[Export ("y", ArgumentSemantic.Retain)]
		SVGLength Y { get; }

		// @property (readonly, retain, nonatomic) SVGLength * dx;
		[Export ("dx", ArgumentSemantic.Retain)]
		SVGLength Dx { get; }

		// @property (readonly, retain, nonatomic) SVGLength * dy;
		[Export ("dy", ArgumentSemantic.Retain)]
		SVGLength Dy { get; }

		// @property (readonly, retain, nonatomic) SVGLength * rotate;
		[Export ("rotate", ArgumentSemantic.Retain)]
		SVGLength Rotate { get; }
	}

	// @interface SVGTextElement : SVGTextPositioningElement <SVGTransformable, ConverterSVGToCALayer>
	[Protocol]
	[BaseType (typeof (SVGTextPositioningElement))]
	interface SVGTextElement : SVGTransformable, ConverterSVGToCALayer {

	}

	// @interface TinySVGTextAreaElement : SVGTextElement
	[Protocol]
	[BaseType (typeof (SVGTextElement))]
	interface TinySVGTextAreaElement {

		// @property (readonly, retain, nonatomic) SVGLength * width;
		[Export ("width", ArgumentSemantic.Retain)]
		SVGLength Width { get; }

		// @property (readonly, retain, nonatomic) SVGLength * height;
		[Export ("height", ArgumentSemantic.Retain)]
		SVGLength Height { get; }
	}

	// @interface SVGKit : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface SVGKit {

		// +(void)enableLogging;
		[Static, Export ("enableLogging")]
		void EnableLogging ();
	}
}


