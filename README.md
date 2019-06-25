# odata-api

What – OData是什么？
OData - Open Data Protocol，是一个设计和使用RESTful API的标准。REST本身只是一个构建web服务的思想和理念，其没有规定一个统一的标准来限制开发人员该如何设计RESTful API。其实我们实际开发中的确也没有遵循某个统一的标准去设计WebAPI。因为大多数场景下，遵循一个统一的标准并不是必要的。但在某些场景下，有这样一个标准却能带来很大的好处。
OData的理想是, 无论哪个组织构建的RESTful API，只要其符合OData标准。其他组织就可以按照OData标准中定义的方式去使用这个API获取/修改资源。这个可以类比SQL标准之于RDBMS关系。无论什么关系型数据库，如果其声称支持SQL 标准，任何人就可以使用标准SQL查询语句来查询数据。
标准化的另一个好处：可以将Odata协议实现到一个通用的类库中，通过这个类库去创建和访问RESTful API可以减少开发人员的工作量。官网上有很多这样的组件。
 
Who - 谁发布了OData？
该标准由微软发起，前三个版本1.0、2.0、3.0都是微软开放标准。
 
When - 什么时候成为了工业标准？
第四个版本4.0于2014年3月17日在OASIS投票通过成为开放工业标准
 
Why – 为什么需要OData？
OData是一个协议，一个标准。所以这个问题等同于为什么我们需要协议。类比TCP协议就可以理解一般。假设你开发的组件必须要和某个第三方组件通信，如果第三方组件不支持TCP而只支持其内部开发的一个私有协议，你就肯定头大了，你必须在你的组件里单独为其实现这个私有协议。如果大家都支持TCP协议，不就省事了么。这就是标准协议的作用：协议和标准用于制定一个统一通用的规则。 我们只需要按照这个协议或标准生产组件，那么这个组件就可以方便的和其他组件集成/协作。而无须根据其他组件的私有标准定制化组件。
 
前面说到Rest只是一种设计Web服务的思想，不是一种标准化的协议。正由于缺乏标准化，从而导致各家公布的Restful API 统一通用方面的欠缺。OData就是为弥补这种欠缺而被提出来的标准协议。


参考链接：
http://www.cnblogs.com/fzrain/p/3923727.html
https://www.youtube.com/watch?v=z06bl_K6Ckc
https://docs.microsoft.com/en-us/aspnet/web-api/overview/odata-support-in-aspnet-web-api/odata-v4/create-an-odata-v4-endpoint 
https://www.cnblogs.com/Leo_wl/p/4618930.html
 https://www.cnblogs.com/1zhk/p/5356053.html
http://odata.github.io/WebApi/#01-02-getting-started https://docs.microsoft.com/zh-tw/aspnet/web-api/overview/odata-support-in-aspnet-web-api/odata-v4/entity-relations-in-odata-v4

https://blog.csdn.net/daimeisi123/article/details/46776725

https://www.cnblogs.com/tukzer/p/3669418.html


$count=true 总页数
 $skip=10 跳过的页数
逻辑操作符
eq: 等于 (Equal)
ne: 不等于 (Not equal)
gt: 大于 (Greater than)
ge: 大le于或等于 (Greater than or equal)
lt: 小于 (Less than)
le: 小于或等于 (Less than or equal)

$filter=contains(CompanyName,'Alfreds')
$filter=indexof(CompanyName, 'Alfreds') gt -1

--------------------- 
字符串操作符
主要掌握：substringof, startswith 和 endswith
sap.ui.model.fiterOperator定义了相应的操作符，但是对于 and/or 采取了不同的方法。
sap.ui.model.FilterOperator.EQ: 对应 eq
sap.ui.model.FilterOperator.NE: 对应 ne
sap.ui.model.FilterOperator.GT: 对应 gt
sap.ui.model.FilterOperator.GE: 对应 ge
sap.ui.model.FilterOperator.LT: 对应 lt
sap.ui.model.FilterOperator.LE: 对应 le
sap.ui.model.FilterOperator.Contains: 对应 substringof
sap.ui.model.FilterOperator.StartsWidth: 对应 startswith
sap.ui.model.FilterOperator.EndsWith: 对应 endswith
--------------------- 
