using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class GetNearestPoint : MonoBehaviour
{
   //スプライン
   [SerializeField] private SplineContainer _spline;
   
   //オブジェクトの位置
   [SerializeField] private Transform inputPoint;
   
   // 解像度
   // 内部的にPickResolutionMin～PickResolutionMaxの範囲に丸められる
   [SerializeField] 
   [Range(SplineUtility.PickResolutionMin, SplineUtility.PickResolutionMax)]
   private int _resolution = 4;

   // 計算回数
   // 内部的に10回以下に丸められる
   [SerializeField]
   [Range(1, 10)]
   private int _iterations = 2;

   private void Update()
   {
      float distance = GetPonit();
      if (distance < 1f)
      {
         Debug.Log(distance);
      }
   }

   private float GetPonit()
   {
      using var spline = new NativeSpline(_spline.Spline, _spline.transform.localToWorldMatrix);

      // スプラインにおける直近位置を求める
      var distance = SplineUtility.GetNearestPoint(
         spline,
         inputPoint.position,
         out var nearest,
         out var t,
         _resolution,
         _iterations
      );

      return distance;
   }
}
