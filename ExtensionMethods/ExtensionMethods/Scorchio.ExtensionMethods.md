<a name='contents'></a>
# Contents [#](#contents 'Go To Here')

- [DateTimeExtensions](#T-Scorchio-ExtensionMethods-DateTimeExtensions 'Scorchio.ExtensionMethods.DateTimeExtensions')
  - [IsTimeEqual(instance,timeToCompare)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsTimeEqual-System-DateTime,System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.IsTimeEqual(System.DateTime,System.DateTime)')
  - [IsToday(instance)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsToday-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.IsToday(System.DateTime)')
  - [IsTomorrow(instance)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsTomorrow-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.IsTomorrow(System.DateTime)')
  - [IsWeekDay(instance)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsWeekDay-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.IsWeekDay(System.DateTime)')
  - [IsWeekendDay(instance)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsWeekendDay-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.IsWeekendDay(System.DateTime)')
  - [IsYesterday(instance)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsYesterday-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.IsYesterday(System.DateTime)')
  - [StartOfYear(instance)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-StartOfYear-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.StartOfYear(System.DateTime)')
  - [Tomorrow(instance)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-Tomorrow-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.Tomorrow(System.DateTime)')
  - [Yesterday(instance)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-Yesterday-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.Yesterday(System.DateTime)')
- [ObjectExtensions](#T-Scorchio-ExtensionMethods-ObjectExtensions 'Scorchio.ExtensionMethods.ObjectExtensions')
  - [SerializeToXml(instance)](#M-Scorchio-ExtensionMethods-ObjectExtensions-SerializeToXml-System-Object- 'Scorchio.ExtensionMethods.ObjectExtensions.SerializeToXml(System.Object)')
- [StringExtensions](#T-Scorchio-ExtensionMethods-StringExtensions 'Scorchio.ExtensionMethods.StringExtensions')
  - [LowerCaseFirstCharacter(instance)](#M-Scorchio-ExtensionMethods-StringExtensions-LowerCaseFirstCharacter-System-String- 'Scorchio.ExtensionMethods.StringExtensions.LowerCaseFirstCharacter(System.String)')
  - [Obfuscate(instance,startPoint,length,character)](#M-Scorchio-ExtensionMethods-StringExtensions-Obfuscate-System-String,System-Int32,System-Int32,System-Char- 'Scorchio.ExtensionMethods.StringExtensions.Obfuscate(System.String,System.Int32,System.Int32,System.Char)')
  - [ToTitleCase(instance)](#M-Scorchio-ExtensionMethods-StringExtensions-ToTitleCase-System-String- 'Scorchio.ExtensionMethods.StringExtensions.ToTitleCase(System.String)')
  - [UpperCaseFirstCharacter(instance)](#M-Scorchio-ExtensionMethods-StringExtensions-UpperCaseFirstCharacter-System-String- 'Scorchio.ExtensionMethods.StringExtensions.UpperCaseFirstCharacter(System.String)')
- [XElementExtensions](#T-Scorchio-ExtensionMethods-XElementExtensions 'Scorchio.ExtensionMethods.XElementExtensions')
  - [GetAttributeValueOrDefault(instance,attributeName,defaultValue)](#M-Scorchio-ExtensionMethods-XElementExtensions-GetAttributeValueOrDefault-System-Xml-Linq-XElement,System-String,System-String- 'Scorchio.ExtensionMethods.XElementExtensions.GetAttributeValueOrDefault(System.Xml.Linq.XElement,System.String,System.String)')
  - [GetElementValueOrDefault(instance,elementName,defaultValue)](#M-Scorchio-ExtensionMethods-XElementExtensions-GetElementValueOrDefault-System-Xml-Linq-XElement,System-String,System-String- 'Scorchio.ExtensionMethods.XElementExtensions.GetElementValueOrDefault(System.Xml.Linq.XElement,System.String,System.String)')

<a name='assembly'></a>
# Scorchio.ExtensionMethods [#](#assembly 'Go To Here') [=](#contents 'Back To Contents')

<a name='T-Scorchio-ExtensionMethods-DateTimeExtensions'></a>
## DateTimeExtensions [#](#T-Scorchio-ExtensionMethods-DateTimeExtensions 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.ExtensionMethods

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-IsTimeEqual-System-DateTime,System-DateTime-'></a>
### IsTimeEqual(instance,timeToCompare) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsTimeEqual-System-DateTime,System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether [is time equal] [the specified time to compare].

##### Returns

`true` if [is time equal] [the specified time to compare]; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The instance. |
| timeToCompare | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The time to compare. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-IsToday-System-DateTime-'></a>
### IsToday(instance) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsToday-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether this instance is today.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The instance. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-IsTomorrow-System-DateTime-'></a>
### IsTomorrow(instance) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsTomorrow-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether this instance is tomorrow.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The instance. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-IsWeekDay-System-DateTime-'></a>
### IsWeekDay(instance) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsWeekDay-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether [is week day].

##### Returns

`true` if [is week day] [the specified instance]; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The instance. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-IsWeekendDay-System-DateTime-'></a>
### IsWeekendDay(instance) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsWeekendDay-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether [is weekend day].

##### Returns

`true` if [is weekend day] [the specified instance]; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The instance. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-IsYesterday-System-DateTime-'></a>
### IsYesterday(instance) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsYesterday-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether this instance is yesterday.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The instance. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-StartOfYear-System-DateTime-'></a>
### StartOfYear(instance) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-StartOfYear-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Starts the of year.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The instance. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-Tomorrow-System-DateTime-'></a>
### Tomorrow(instance) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-Tomorrow-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Tomorrows the specified instance.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The instance. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-Yesterday-System-DateTime-'></a>
### Yesterday(instance) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-Yesterday-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Yesterdays the specified instance.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The instance. |

<a name='T-Scorchio-ExtensionMethods-ObjectExtensions'></a>
## ObjectExtensions [#](#T-Scorchio-ExtensionMethods-ObjectExtensions 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.ExtensionMethods

<a name='M-Scorchio-ExtensionMethods-ObjectExtensions-SerializeToXml-System-Object-'></a>
### SerializeToXml(instance) `method` [#](#M-Scorchio-ExtensionMethods-ObjectExtensions-SerializeToXml-System-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Serializes to Xml.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The instance. |

<a name='T-Scorchio-ExtensionMethods-StringExtensions'></a>
## StringExtensions [#](#T-Scorchio-ExtensionMethods-StringExtensions 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.ExtensionMethods

<a name='M-Scorchio-ExtensionMethods-StringExtensions-LowerCaseFirstCharacter-System-String-'></a>
### LowerCaseFirstCharacter(instance) `method` [#](#M-Scorchio-ExtensionMethods-StringExtensions-LowerCaseFirstCharacter-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Lower cases the first character.

##### Returns

The string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The instance. |

<a name='M-Scorchio-ExtensionMethods-StringExtensions-Obfuscate-System-String,System-Int32,System-Int32,System-Char-'></a>
### Obfuscate(instance,startPoint,length,character) `method` [#](#M-Scorchio-ExtensionMethods-StringExtensions-Obfuscate-System-String,System-Int32,System-Int32,System-Char- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Obfuscates the substring.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The instance. |
| startPoint | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The start point. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length. |
| character | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The character. |

<a name='M-Scorchio-ExtensionMethods-StringExtensions-ToTitleCase-System-String-'></a>
### ToTitleCase(instance) `method` [#](#M-Scorchio-ExtensionMethods-StringExtensions-ToTitleCase-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

To the title case.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The instance. |

<a name='M-Scorchio-ExtensionMethods-StringExtensions-UpperCaseFirstCharacter-System-String-'></a>
### UpperCaseFirstCharacter(instance) `method` [#](#M-Scorchio-ExtensionMethods-StringExtensions-UpperCaseFirstCharacter-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Uppercases the first character.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The instance. |

<a name='T-Scorchio-ExtensionMethods-XElementExtensions'></a>
## XElementExtensions [#](#T-Scorchio-ExtensionMethods-XElementExtensions 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.ExtensionMethods

<a name='M-Scorchio-ExtensionMethods-XElementExtensions-GetAttributeValueOrDefault-System-Xml-Linq-XElement,System-String,System-String-'></a>
### GetAttributeValueOrDefault(instance,attributeName,defaultValue) `method` [#](#M-Scorchio-ExtensionMethods-XElementExtensions-GetAttributeValueOrDefault-System-Xml-Linq-XElement,System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the attribute value or default.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The instance. |
| attributeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the attribute. |
| defaultValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The default value. |

<a name='M-Scorchio-ExtensionMethods-XElementExtensions-GetElementValueOrDefault-System-Xml-Linq-XElement,System-String,System-String-'></a>
### GetElementValueOrDefault(instance,elementName,defaultValue) `method` [#](#M-Scorchio-ExtensionMethods-XElementExtensions-GetElementValueOrDefault-System-Xml-Linq-XElement,System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the element value or default.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The instance. |
| elementName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the element. |
| defaultValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The default value. |
