/****************************************************************************
 * Copyright (c) 2017 zhuhaoqiao@putao.com
 * 
 * http://liangxiegame.com
 * https://github.com/liangxiegame/QFramework
 * https://github.com/liangxiegame/QSingleton
 * https://github.com/liangxiegame/QChain
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 ****************************************************************************/

#if UNITY
namespace QFramework
{
    using NUnit.Framework;

    public class FSMLiteTest
    {
        QFSMLite mFSMLite = new QFSMLite();

        [Test]
		public void FSMLiteTest_AddTranslation()
		{
			string str1 = "work->rest true";
			string str2 = "work->rest false";
			mFSMLite.AddState ("work");
			mFSMLite.AddState ("rest");

			mFSMLite.AddTranslation ("work", "work->rest", "rest", delegate {
				str2="work->rest true";
			});

			mFSMLite.Start ("work");

			mFSMLite.HandleEvent ("work->rest");

			Assert.IsNotNull(mFSMLite);
			Assert.AreEqual (str1, str2);
		}
	}
}
#endif