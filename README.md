# TranslationBot
Twich チャットを翻訳してチャット ボットで書き込む
<br />
# 動作環境
Windows 10 以降の 64bit 版でしか動作しません。  
.NET Framework 4.7.1 を使用  
<br />
# インストール方法
特に無し  
<br />
# アンインストール方法
レジストリは弄っていません。  
設定は AppData\Local\TranslationBot に保存されています。  
<br />
# 使用方法
Microsoft Azure の翻訳サービスが必要です。  
<br />
Bot-User-Name には翻訳したチャットを書き込むユーザー名を入力してください。  
Bot-Token には https://twitchtokengenerator.com/ で ACCESS TOKEN を取得してください。  
Channel-Name には自分のユーザー名を入力してください。  
<br />
Command-Name 、Begin-Tag-Pattern 、 End-Tag-Pattern にそれぞれ  
translate<br />
^[{\[] *(?i)<br />
&nbsp;*[}\]]<br />
と入力すれば {translate} [translate] が翻訳コマンドになります({translate}Hello でこんにちはと書き込まれます)。  
Force Translation にチェックすればコマンドとは関係無しに翻訳されます。  
<br />
# 免責
作者はこのソフトによって生じた如何なる損害の責任を負わない事とします。  
また修正や更新も基本行いませんので、使用は自己責任でお願いします。  
<br />
# 作者
エトゼ  
https://twitter.com/cvaeoi  
