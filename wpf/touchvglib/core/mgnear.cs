/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

using System;
using System.Runtime.InteropServices;

public class mgnear : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal mgnear(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(mgnear obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~mgnear() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_mgnear(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static float nearestOnBezier(Point2d pt, Point2d pts, Point2d nearpt) {
    float ret = touchvgPINVOKE.mgnear_nearestOnBezier(Point2d.getCPtr(pt), Point2d.getCPtr(pts), Point2d.getCPtr(nearpt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void beziersBox(Box2d box, int count, Point2d points, bool closed) {
    touchvgPINVOKE.mgnear_beziersBox__SWIG_0(Box2d.getCPtr(box), count, Point2d.getCPtr(points), closed);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void beziersBox(Box2d box, int count, Point2d points) {
    touchvgPINVOKE.mgnear_beziersBox__SWIG_1(Box2d.getCPtr(box), count, Point2d.getCPtr(points));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public static bool beziersIntersectBox(Box2d box, int count, Point2d points, bool closed) {
    bool ret = touchvgPINVOKE.mgnear_beziersIntersectBox__SWIG_0(Box2d.getCPtr(box), count, Point2d.getCPtr(points), closed);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool beziersIntersectBox(Box2d box, int count, Point2d points) {
    bool ret = touchvgPINVOKE.mgnear_beziersIntersectBox__SWIG_1(Box2d.getCPtr(box), count, Point2d.getCPtr(points));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void cubicSplinesBox(Box2d box, int n, Point2d knots, Vector2d knotvs, bool closed) {
    touchvgPINVOKE.mgnear_cubicSplinesBox__SWIG_0(Box2d.getCPtr(box), n, Point2d.getCPtr(knots), Vector2d.getCPtr(knotvs), closed);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void cubicSplinesBox(Box2d box, int n, Point2d knots, Vector2d knotvs) {
    touchvgPINVOKE.mgnear_cubicSplinesBox__SWIG_1(Box2d.getCPtr(box), n, Point2d.getCPtr(knots), Vector2d.getCPtr(knotvs));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public static bool cubicSplinesIntersectBox(Box2d box, int n, Point2d knots, Vector2d knotvs, bool closed) {
    bool ret = touchvgPINVOKE.mgnear_cubicSplinesIntersectBox__SWIG_0(Box2d.getCPtr(box), n, Point2d.getCPtr(knots), Vector2d.getCPtr(knotvs), closed);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool cubicSplinesIntersectBox(Box2d box, int n, Point2d knots, Vector2d knotvs) {
    bool ret = touchvgPINVOKE.mgnear_cubicSplinesIntersectBox__SWIG_1(Box2d.getCPtr(box), n, Point2d.getCPtr(knots), Vector2d.getCPtr(knotvs));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void getRectHandle(Box2d rect, int index, Point2d pt) {
    touchvgPINVOKE.mgnear_getRectHandle(Box2d.getCPtr(rect), index, Point2d.getCPtr(pt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void moveRectHandle(Box2d rect, int index, Point2d pt, bool lockCornerScale) {
    touchvgPINVOKE.mgnear_moveRectHandle__SWIG_0(Box2d.getCPtr(rect), index, Point2d.getCPtr(pt), lockCornerScale);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void moveRectHandle(Box2d rect, int index, Point2d pt) {
    touchvgPINVOKE.mgnear_moveRectHandle__SWIG_1(Box2d.getCPtr(rect), index, Point2d.getCPtr(pt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public mgnear() : this(touchvgPINVOKE.new_mgnear(), true) {
  }

}

}
