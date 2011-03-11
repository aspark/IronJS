using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests.Sputnik {
  [TestClass]
  public class Conformance_11_Expressions_11_3_PostfixExpressions_11_3_2_Postfix_Decrement_Operator : BaseTest {
    [TestInitialize]
    public void Init() { SetSputnikDir(@"Conformance\11_Expressions\11.3_PostfixExpressions\11.3.2_Postfix_Decrement_Operator"); }
    [TestMethod] public void S11_3_2_A1_1_T1_js() { RunFile(@"S11.3.2_A1.1_T1.js"); }
    [TestMethod] public void S11_3_2_A1_1_T2_js() { RunFile(@"S11.3.2_A1.1_T2.js"); }
    [TestMethod] public void S11_3_2_A1_1_T3_js() { RunFile(@"S11.3.2_A1.1_T3.js"); }
    [TestMethod] public void S11_3_2_A1_1_T4_js() { RunFile(@"S11.3.2_A1.1_T4.js"); }
    [TestMethod] public void S11_3_2_A1_2_T1_js() { RunFile(@"S11.3.2_A1.2_T1.js"); }
    [TestMethod] public void S11_3_2_A2_1_T1_js() { RunFile(@"S11.3.2_A2.1_T1.js"); }
    [TestMethod] public void S11_3_2_A2_1_T2_js() { RunFile(@"S11.3.2_A2.1_T2.js"); }
    [TestMethod] public void S11_3_2_A2_1_T3_js() { RunFile(@"S11.3.2_A2.1_T3.js"); }
    [TestMethod] public void S11_3_2_A2_2_T1_js() { RunFile(@"S11.3.2_A2.2_T1.js"); }
    [TestMethod] public void S11_3_2_A3_T1_js() { RunFile(@"S11.3.2_A3_T1.js"); }
    [TestMethod] public void S11_3_2_A3_T2_js() { RunFile(@"S11.3.2_A3_T2.js"); }
    [TestMethod] public void S11_3_2_A3_T3_js() { RunFile(@"S11.3.2_A3_T3.js"); }
    [TestMethod] public void S11_3_2_A3_T4_js() { RunFile(@"S11.3.2_A3_T4.js"); }
    [TestMethod] public void S11_3_2_A3_T5_js() { RunFile(@"S11.3.2_A3_T5.js"); }
    [TestMethod] public void S11_3_2_A4_T1_js() { RunFile(@"S11.3.2_A4_T1.js"); }
    [TestMethod] public void S11_3_2_A4_T2_js() { RunFile(@"S11.3.2_A4_T2.js"); }
    [TestMethod] public void S11_3_2_A4_T3_js() { RunFile(@"S11.3.2_A4_T3.js"); }
    [TestMethod] public void S11_3_2_A4_T4_js() { RunFile(@"S11.3.2_A4_T4.js"); }
    [TestMethod] public void S11_3_2_A4_T5_js() { RunFile(@"S11.3.2_A4_T5.js"); }
  }
}