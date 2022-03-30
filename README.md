RoutereetView
=======
KMLファイルを読み込んで、サクッとGoogleストリートビューを表示し、道路を確認するためのアプリです。  
サイクリングコースの事前確認のために開発しました。  
Static API を使用しているため、Google Earth 等のアプリ上で確認するより、圧倒的に高速かつ軽快に動作します。

MITライセンス。

![画面キャプチャ](https://raw.githubusercontent.com/tacores/RoutereetView/master/images/capture.png)

# 使用方法
1. Garmin Connect でGPXファイルを出力し、オンラインでKMLファイルに変換します。(https://gpx2kml.com/)
2. [release](https://github.com/tacores/RoutereetView/releases)からZIPファイルをダウンロードして解凍します。
3. 解凍したフォルダ内の RoutereetView.exeをダブルクリックして起動します。
4. 「Open KML」ボタンを押下し、KMLファイルを選択して開きます。
5. 平面マップと標高マップが表示されます。
6. 平面マップか標高マップで、ストリートビューを表示したい部分をクリックします。
7. ストリートビューが表示されます。

# 備考
1. 平面マップは正方形に合わせて伸縮させているので、実際の距離感と異なります。
2. 日本国内のGPSデータでしかテストしていません。南半球等のデータは正常に表示されないかもしれません。

# 開発者向け情報
1. 開発環境はVisualStudio2022。
2. Google APIキー（APIKey.cs）の中身はダミーです。自分でビルドする場合は、各自APIキーを取得、設定してください。


