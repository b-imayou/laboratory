﻿# 目盛りのないストップウォッチ (ID 0416)

図のようなストップウォッチがあります．  
このストップウォッチには０を示す目印が一つあるだけで，目盛りがありません．  
起動した瞬間，針は目印を指し，そこから針は軸を中心に一定の割合で時計回りに回転します．  
目盛りがないので，起動からの経過時間を直接読み取ることはできません．  
その代わり，針が目印から時計回りに a 度回ったときの経過時間が t 秒であることがわかっています．  
ただし，a は 360 度未満とします．  
  
角度 a と経過時間 t が与えられたとき，  
ストップウォッチ起動後に読み取った針の角度 r が
表す経過時間を求めるプログラムを作成せよ．  
ただし，針が 1 周していないことはわかって
いるものとする．

## 入力

１行に角度 a (1 ≤ a ≤ 359) と角度 a のときの経過時間 t (1 ≤ t ≤ 1, 000)，  
読み取った角度 r(0 ≤ r ≤ 359) がすべて整数で与えられる．  
ただし，a と r の単位は度，t の単位は秒とする．
## 出力

読み取った針の角度が表す経過時間を秒で１行に実数で出力する．ただし，誤差がプラスマ
イナス 0.001 を超えてはならない．

## 入出力例

### 例1

|入力|出力|
|---|---|
|`180 120 90`|`60.0`|

### 例2

|入力|出力|
|---|---|
|`90 100 120`|`133.33333`|
