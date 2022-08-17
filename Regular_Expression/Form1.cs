using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regular_Expression
{
    public partial class Form1 : Form
    {
        DataTable _dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegTableSetting();
        }

        private void RegTableSetting()
        {
            _dt = new DataTable("Regular Table");  // 1

            // DataColumn 생성 2
            DataColumn colRegName = new DataColumn("Name",typeof(string));
            DataColumn colRegData = new DataColumn("Data", typeof(string));
            DataColumn colRegSample = new DataColumn("Sample", typeof(string));

            // Column을 DataTable에 추가 3
            _dt.Columns.Add(colRegName);
            _dt.Columns.Add(colRegData);
            _dt.Columns.Add(colRegSample);


            //DataRow dr = _dt.NewRow();
            //dr["Name"] = .....
            _dt.Rows.Add(RegexDataRow(_dt.NewRow(), "ETC_문자열체크", @"List<\w+>", @"List<변수> 가 있는지를 비교"));
            _dt.Rows.Add(RegexDataRow(_dt.NewRow(), "ETC_지정문자", @"(H|h)ong", @"Hong, hong를 찾음"));
            _dt.Rows.Add(RegexDataRow(_dt.NewRow(), "ETC_문자만", @"\D+", "12 54 78 5 9"));
            _dt.Rows.Add(RegexDataRow(_dt.NewRow(), "IsMatch_전화번호", @"^01[01678]-[0-9]{4}-[0-9]{4}$", "000-0000-0000"));
            _dt.Rows.Add(RegexDataRow(_dt.NewRow(), "IsMatch_이름(한글3자리)", @"^[가-힣]{3}$", "홍길동"));
            _dt.Rows.Add(RegexDataRow(_dt.NewRow(), "IsMatch_숫자만", @"^[0-9]", "1234567890"));
            _dt.Rows.Add(RegexDataRow(_dt.NewRow(), "IsMatch_영어만", @"^[a-zA-Z]", "abcdEFGH"));
            _dt.Rows.Add(RegexDataRow(_dt.NewRow(), "IsMatch_URL주소", @"(http|https)://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?", "https://naver.com/"));
            _dt.Rows.Add(RegexDataRow(_dt.NewRow(), "IsMatch_주민등록번호", @"[0-9][0-9][01][0-9][0123][0-9]-[1234][0-9]{6}", "000000-2000000"));
            _dt.Rows.Add(RegexDataRow(_dt.NewRow(), "IsMatch_특수문자제외", @"^[a-zA-Z0-9ㄱ-힣]*$", "abcd가나다라1234"));


            dgRegex.DataSource = _dt;
            dgRegex.AutoResizeColumns();
        }

        private DataRow RegexDataRow(DataRow dr,string strName, string strData, string strSample)
        {
            cboxRegexName.Items.Add(strName);

            dr["Name"] = strName;
            dr["Data"] = strData;
            dr["Sample"] = strSample;

            return dr;
        }

        
        private void cboxRegexName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DataTable에서 Select을 해서 Row(ComboBox에서 선택된)를 가져옴
            DataRow[] dRow = _dt.Select($"Name = '{cboxRegexName.SelectedItem}'"); 

            lblFormat.Text = dRow[0]["Data"].ToString();  
            lblSample.Text = dRow[0]["Sample"].ToString();

        }

        /// <summary>
        /// Check Result를 보고 상황 체크
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataCheck_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(lblFormat.Text);

            // 입력 요소가 처음 발견 된 위치,값
            if (rdoMatch.Checked)
            {
                Match match = regex.Match(tboxCheckData.Text);
                if (match.Success)
                {
                    int iPosition = match.Index;
                    string sValue = match.Value.ToString();
                    lblResult.Text = "OK";
                    lblErrorMsg.Text = $"[{iPosition}]위치에서 [{sValue}]값을 찾았습니다.";
                }
                else
                {
                    lblResult.Text = "NOT FOUND";
                    lblErrorMsg.Text = "정규식과 일치하는 데이터가 없습니다.";
                }
            }

            // 이 형식이 맞는가?
            else if (rdoIsMatch.Checked)
            {
                if (regex.IsMatch(tboxCheckData.Text))
                {
                    lblResult.Text = "OK";
                    lblErrorMsg.Text = "사용 가능한 형식 입니다.";
                }
                else
                {
                    lblResult.Text = "NOT FOUND";
                    lblErrorMsg.Text = $"[{tboxCheckData.Text}]는 사용 할 수 없는 형식 입니다. [{lblSample.Text}]를 참조하세요.";
                }
            }

            // 지정 문자열을 기준으로 잘라낸다. 지정 문자열은 잘라짐
            else if (rdoSplit.Checked)
            {
                string[] sData = regex.Split(tboxCheckData.Text);  //Split은 string[]을 반환
                string sResult = string.Join(" ", sData);

                if (sResult != "")
                {
                    lblResult.Text = "OK";
                    lblErrorMsg.Text = $"결과: {sResult}";
                }
                else
                {
                    lblResult.Text = "NOT FOUND";
                    lblErrorMsg.Text = "정규식과 일치하는 데이터가 없습니다.";
                }


            }

            // 문자열를 변경한다 A->B
            else if (rdoReplace.Checked)
            {
                string sData = regex.Replace(tboxCheckData.Text, tboxReplace.Text);

                if (sData != "")
                {
                    lblResult.Text = "OK";
                    lblErrorMsg.Text = $"결과: {sData}";
                }
                else
                {
                    lblResult.Text = "NOT FOUND";
                    lblErrorMsg.Text = "정규식과 일치하는 데이터가 없습니다.";
                }
            }

        }


    }
}
