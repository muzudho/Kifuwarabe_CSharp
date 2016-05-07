
namespace Grayscale.P027_Settei_____.L500____Struct
{
    public abstract class Const_Filepath
    {
        /// <summary>
        /// データ・フォルダー。
        /// (将棋エンジン).exeファイルから Engine01_Config フォルダーへの相対パス☆　末尾にスラッシュ付き。
        /// </summary>
        public const string m_EXE_TO_CONFIG = "../../Engine01_Config/";

        /// <summary>
        /// fvフォルダー。
        /// Engine01_Config フォルダーからFvフォルダーへの相対パス☆　末尾にスラッシュ付き。
        /// </summary>
        public const string m_CONFIG_TO_FV = "fv/";

        /// <summary>
        /// データ・フォルダー。
        /// AIMS.exeファイルから Engine01_Config フォルダーへの相対パス☆　末尾にスラッシュ付き。
        /// </summary>
        public const string m_AIMS_TO_CONFIG = "./CSharp/Engine01_Config/";

        /// <summary>
        /// ログ・フォルダー。
        /// (将棋エンジン).exeファイルから Engine01_Logs フォルダーへの相対パス☆　末尾にスラッシュ付き。
        /// </summary>
        public const string m_EXE_TO_LOGGINGS = "../../Engine01_Logs/";
    }
}
