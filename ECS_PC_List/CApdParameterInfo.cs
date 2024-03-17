using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_ChangeToCSV
{
    //public class CApdParameterInfo
    //{
    //    public List<string> mHeaderName = new List<string>();

    //    public CApdParameterInfo(string str)
    //    {
    //        string[] tempStr = str.Split(',');

    //        for (int i = 0; i < tempStr.Length; i++)
    //        {
    //            mHeaderName.Add(tempStr[i]);
    //        }
    //    }

    //    //public HeaderInfo(params string[] list)
    //    //{
    //    //    for (int i = 0; i < list.Length; i++)
    //    //    {
    //    //        mHeaderName.Add(list[i]);
    //    //    }
    //    //}

    //    public bool IsSame(string str)
    //    {
    //        str = str.ToUpper();
    //        for (int i = 0; i < mHeaderName.Count; i++)
    //        {
    //            if (str.Equals(mHeaderName[i].ToUpper()))
    //            {
    //                return true;
    //            }
    //        }
    //        return false;
    //    }
    //}

    public class CAPDParameter
    {
        private string _ApdNo = "";
        public string ApdNo
        {
            get { return _ApdNo; }
            set { _ApdNo = value; }
        }

        private string _ApdID = "";
        public string ApdID
        {
            get { return _ApdID; }
            set { _ApdID = value; }
        }

        private string _ApdDescription = "";
        public string ApdDescription
        {
            get { return _ApdDescription; }
            set { _ApdDescription = value; }
        }

        private string _ApdDataType = "";
        public string ApdDataType
        {
            get { return _ApdDataType; }
            set { _ApdDataType = value; }
        }

        private string _ApdSubDataType = "";
        public string ApdSubDataType
        {
            get { return _ApdSubDataType; }
            set { _ApdSubDataType = value; }
        }

        private string _ApdWordSize = "";
        public string ApdWordSize
        {
            get { return _ApdWordSize; }
            set { _ApdWordSize = value; }
        }

        private string _ApdDecimalPlace = "";
        public string ApdDecimalPlace
        {
            get { return _ApdDecimalPlace; }
            set { _ApdDecimalPlace = value; }
        }

        private string _ApdStartAddress = "";
        public string ApdStartAddress
        {
            get { return _ApdStartAddress; }
            set { _ApdStartAddress = value; }
        }

        private string _ApdSign = "";
        public string ApdSign
        {
            get { return _ApdSign; }
            set { _ApdSign = value; }
        }

        private string _ApdGlassIndex = "";
        public string ApdGlassIndex
        {
            get { return _ApdGlassIndex; }
            set { _ApdGlassIndex = value; }
        }

        private string _ApdGroupID = "";
        public string ApdGroupID
        {
            get { return _ApdGroupID; }
            set { _ApdGroupID = value; }
        }

        private string _ApdSubMessage = "";
        public string ApdSubMessage
        {
            get { return _ApdSubMessage; }
            set { _ApdSubMessage = value; }
        }

        private string _ApdDriverConn = "";
        public string ApdDriverConn
        {
            get { return _ApdDriverConn; }
            set { _ApdDriverConn = value; }
        }

        private string _ApdCsvWordSize = "";
        public string ApdCsvWordSize
        {
            get { return _ApdCsvWordSize; }
            set { _ApdCsvWordSize = value; }
        }
        private string _ApdNullValue = "";
        public string ApdNullValue
        {
            get { return _ApdNullValue; }
            set { _ApdNullValue = value; }
        }

        public void ClearValue()
        {
            _ApdNo = "";
            _ApdID = "";
            _ApdDescription = "";
            _ApdDataType = "";
            _ApdWordSize = "";
            _ApdDecimalPlace = "";
            _ApdStartAddress = "";
            _ApdSign = "";
            _ApdGlassIndex = "";
            _ApdGroupID = "";
            _ApdSubMessage = "";
            _ApdDriverConn = "";
            _ApdCsvWordSize = "0";
            _ApdSubDataType = "";
            _ApdSubMessage = "";          
            _ApdNullValue = "";
        }
    }

    public class CHeaderItem
    {
        private string _HeaderKey = "";
        public string HeaderKey
        {
            get { return _HeaderKey; }
            set { _HeaderKey = value; }
        }

        private string[] _HeaderValue = null;
        public string[] HeaderValue
        {
            get { return _HeaderValue; }
            set { _HeaderValue = value; }
        }

        private bool _HeaderValidation = false;
        public bool HeaderValidation
        {
            get { return _HeaderValidation; }
            set { _HeaderValidation = value; }
        }
    } 
    public class CHeaderItemList : List<CHeaderItem>
    {

    }

    public class CDataTypeItem
    {

        private string _DataTypeKey = "";
        public string DataTypeKey
        {
            get { return _DataTypeKey; }
            set { _DataTypeKey = value; }
        }

        private string[] _DataTypeValue = null;
        public string[] DataTypeValue
        {
            get { return _DataTypeValue; }
            set { _DataTypeValue = value; }
        }
    }
}
