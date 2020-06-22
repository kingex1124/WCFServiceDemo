using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的介面名稱 "IService"。
// 定義一個服務合約 套用在介面、類別
[ServiceContract]
public interface IService
{
	// 介面的方法如果要給外部呼叫，就要加上這個合約
	[OperationContract]
	string GetData(int value);

	[OperationContract]
	float GetStockPrice(int ID);

	[OperationContract]
	CompositeType GetDataUsingDataContract(CompositeType composite);

	// TODO: 在此新增您的服務作業
}

//使用下列範例中所示的資料合約，新增複合型別至服務作業。
// 回傳自定義類別型態時，就要加上這個合約 可以透過網際網路傳送的封包格式 船到用戶端
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
