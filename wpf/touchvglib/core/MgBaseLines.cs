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

public class MgBaseLines : MgBaseShape {
  private HandleRef swigCPtr;

  internal MgBaseLines(IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgBaseLines_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgBaseLines obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new static int Type() {
    int ret = touchvgPINVOKE.MgBaseLines_Type();
    return ret;
  }

  public void setClosed(bool closed) {
    touchvgPINVOKE.MgBaseLines_setClosed(swigCPtr, closed);
  }

  public Point2d endPoint() {
    Point2d ret = new Point2d(touchvgPINVOKE.MgBaseLines_endPoint(swigCPtr), true);
    return ret;
  }

  public bool resize(int count) {
    bool ret = touchvgPINVOKE.MgBaseLines_resize(swigCPtr, count);
    return ret;
  }

  public bool addPoint(Point2d pt) {
    bool ret = touchvgPINVOKE.MgBaseLines_addPoint(swigCPtr, Point2d.getCPtr(pt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool insertPoint(int segment, Point2d pt) {
    bool ret = touchvgPINVOKE.MgBaseLines_insertPoint(swigCPtr, segment, Point2d.getCPtr(pt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool removePoint(int index) {
    bool ret = touchvgPINVOKE.MgBaseLines_removePoint(swigCPtr, index);
    return ret;
  }

  public int maxEdgeIndex() {
    int ret = touchvgPINVOKE.MgBaseLines_maxEdgeIndex(swigCPtr);
    return ret;
  }

  protected MgBaseLines() : this(touchvgPINVOKE.new_MgBaseLines(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("clone", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateMgBaseLines_0(SwigDirectorclone);
    if (SwigDerivedClassHasMethod("copy", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateMgBaseLines_1(SwigDirectorcopy);
    if (SwigDerivedClassHasMethod("release", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateMgBaseLines_2(SwigDirectorrelease);
    if (SwigDerivedClassHasMethod("addRef", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateMgBaseLines_3(SwigDirectoraddRef);
    if (SwigDerivedClassHasMethod("equals", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateMgBaseLines_4(SwigDirectorequals);
    if (SwigDerivedClassHasMethod("getType", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateMgBaseLines_5(SwigDirectorgetType);
    if (SwigDerivedClassHasMethod("isKindOf", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateMgBaseLines_6(SwigDirectorisKindOf);
    if (SwigDerivedClassHasMethod("setOwner", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateMgBaseLines_7(SwigDirectorsetOwner);
    if (SwigDerivedClassHasMethod("getExtent", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateMgBaseLines_8(SwigDirectorgetExtent);
    if (SwigDerivedClassHasMethod("getChangeCount", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateMgBaseLines_9(SwigDirectorgetChangeCount);
    if (SwigDerivedClassHasMethod("resetChangeCount", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateMgBaseLines_10(SwigDirectorresetChangeCount);
    if (SwigDerivedClassHasMethod("afterChanged", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateMgBaseLines_11(SwigDirectorafterChanged);
    if (SwigDerivedClassHasMethod("update", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateMgBaseLines_12(SwigDirectorupdate);
    if (SwigDerivedClassHasMethod("transform", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateMgBaseLines_13(SwigDirectortransform);
    if (SwigDerivedClassHasMethod("clear", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateMgBaseLines_14(SwigDirectorclear);
    if (SwigDerivedClassHasMethod("clearCachedData", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateMgBaseLines_15(SwigDirectorclearCachedData);
    if (SwigDerivedClassHasMethod("getPointCount", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateMgBaseLines_16(SwigDirectorgetPointCount);
    if (SwigDerivedClassHasMethod("getPoint", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateMgBaseLines_17(SwigDirectorgetPoint);
    if (SwigDerivedClassHasMethod("setPoint", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateMgBaseLines_18(SwigDirectorsetPoint);
    if (SwigDerivedClassHasMethod("isClosed", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateMgBaseLines_19(SwigDirectorisClosed);
    if (SwigDerivedClassHasMethod("isCurve", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateMgBaseLines_20(SwigDirectorisCurve);
    if (SwigDerivedClassHasMethod("hitTest", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateMgBaseLines_21(SwigDirectorhitTest);
    if (SwigDerivedClassHasMethod("hitTestBox", swigMethodTypes22))
      swigDelegate22 = new SwigDelegateMgBaseLines_22(SwigDirectorhitTestBox);
    if (SwigDerivedClassHasMethod("draw", swigMethodTypes23))
      swigDelegate23 = new SwigDelegateMgBaseLines_23(SwigDirectordraw);
    if (SwigDerivedClassHasMethod("save", swigMethodTypes24))
      swigDelegate24 = new SwigDelegateMgBaseLines_24(SwigDirectorsave);
    if (SwigDerivedClassHasMethod("load", swigMethodTypes25))
      swigDelegate25 = new SwigDelegateMgBaseLines_25(SwigDirectorload);
    if (SwigDerivedClassHasMethod("getHandleCount", swigMethodTypes26))
      swigDelegate26 = new SwigDelegateMgBaseLines_26(SwigDirectorgetHandleCount);
    if (SwigDerivedClassHasMethod("getHandlePoint", swigMethodTypes27))
      swigDelegate27 = new SwigDelegateMgBaseLines_27(SwigDirectorgetHandlePoint);
    if (SwigDerivedClassHasMethod("setHandlePoint", swigMethodTypes28))
      swigDelegate28 = new SwigDelegateMgBaseLines_28(SwigDirectorsetHandlePoint);
    if (SwigDerivedClassHasMethod("isHandleFixed", swigMethodTypes29))
      swigDelegate29 = new SwigDelegateMgBaseLines_29(SwigDirectorisHandleFixed);
    if (SwigDerivedClassHasMethod("getHandleType", swigMethodTypes30))
      swigDelegate30 = new SwigDelegateMgBaseLines_30(SwigDirectorgetHandleType);
    if (SwigDerivedClassHasMethod("offset", swigMethodTypes31))
      swigDelegate31 = new SwigDelegateMgBaseLines_31(SwigDirectoroffset);
    if (SwigDerivedClassHasMethod("setFlag", swigMethodTypes32))
      swigDelegate32 = new SwigDelegateMgBaseLines_32(SwigDirectorsetFlag);
    touchvgPINVOKE.MgBaseLines_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21, swigDelegate22, swigDelegate23, swigDelegate24, swigDelegate25, swigDelegate26, swigDelegate27, swigDelegate28, swigDelegate29, swigDelegate30, swigDelegate31, swigDelegate32);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(MgBaseLines));
    return hasDerivedMethod;
  }

  private IntPtr SwigDirectorclone() {
    return MgObject.getCPtr(clone()).Handle;
  }

  private void SwigDirectorcopy(IntPtr src) {
    copy(new MgObject(src, false));
  }

  private void SwigDirectorrelease() {
    release();
  }

  private void SwigDirectoraddRef() {
    addRef();
  }

  private bool SwigDirectorequals(IntPtr src) {
    return equals(new MgObject(src, false));
  }

  private int SwigDirectorgetType() {
    return getType();
  }

  private bool SwigDirectorisKindOf(int type) {
    return isKindOf(type);
  }

  private void SwigDirectorsetOwner(IntPtr owner) {
    setOwner((owner == IntPtr.Zero) ? null : new MgShape(owner, false));
  }

  private IntPtr SwigDirectorgetExtent() {
    return Box2d.getCPtr(getExtent()).Handle;
  }

  private int SwigDirectorgetChangeCount() {
    return getChangeCount();
  }

  private void SwigDirectorresetChangeCount(int count) {
    resetChangeCount(count);
  }

  private void SwigDirectorafterChanged() {
    afterChanged();
  }

  private void SwigDirectorupdate() {
    update();
  }

  private void SwigDirectortransform(IntPtr mat) {
    transform(new Matrix2d(mat, false));
  }

  private void SwigDirectorclear() {
    clear();
  }

  private void SwigDirectorclearCachedData() {
    clearCachedData();
  }

  private int SwigDirectorgetPointCount() {
    return getPointCount();
  }

  private IntPtr SwigDirectorgetPoint(int index) {
    return Point2d.getCPtr(getPoint(index)).Handle;
  }

  private void SwigDirectorsetPoint(int index, IntPtr pt) {
    setPoint(index, new Point2d(pt, false));
  }

  private bool SwigDirectorisClosed() {
    return isClosed();
  }

  private bool SwigDirectorisCurve() {
    return isCurve();
  }

  private float SwigDirectorhitTest(IntPtr pt, float tol, IntPtr res) {
    return hitTest(new Point2d(pt, false), tol, new MgHitResult(res, false));
  }

  private bool SwigDirectorhitTestBox(IntPtr rect) {
    return hitTestBox(new Box2d(rect, false));
  }

  private bool SwigDirectordraw(int mode, IntPtr gs, IntPtr ctx, int segment) {
    return draw(mode, new GiGraphics(gs, false), new GiContext(ctx, false), segment);
  }

  private bool SwigDirectorsave(IntPtr s) {
    return save((s == IntPtr.Zero) ? null : new MgStorage(s, false));
  }

  private bool SwigDirectorload(IntPtr factory, IntPtr s) {
    return load((factory == IntPtr.Zero) ? null : new MgShapeFactory(factory, false), (s == IntPtr.Zero) ? null : new MgStorage(s, false));
  }

  private int SwigDirectorgetHandleCount() {
    return getHandleCount();
  }

  private IntPtr SwigDirectorgetHandlePoint(int index) {
    return Point2d.getCPtr(getHandlePoint(index)).Handle;
  }

  private bool SwigDirectorsetHandlePoint(int index, IntPtr pt, float tol) {
    return setHandlePoint(index, new Point2d(pt, false), tol);
  }

  private bool SwigDirectorisHandleFixed(int index) {
    return isHandleFixed(index);
  }

  private int SwigDirectorgetHandleType(int index) {
    return getHandleType(index);
  }

  private bool SwigDirectoroffset(IntPtr vec, int segment) {
    return offset(new Vector2d(vec, false), segment);
  }

  private void SwigDirectorsetFlag(int bit, bool on) {
    setFlag((MgShapeBit)bit, on);
  }

  public delegate IntPtr SwigDelegateMgBaseLines_0();
  public delegate void SwigDelegateMgBaseLines_1(IntPtr src);
  public delegate void SwigDelegateMgBaseLines_2();
  public delegate void SwigDelegateMgBaseLines_3();
  public delegate bool SwigDelegateMgBaseLines_4(IntPtr src);
  public delegate int SwigDelegateMgBaseLines_5();
  public delegate bool SwigDelegateMgBaseLines_6(int type);
  public delegate void SwigDelegateMgBaseLines_7(IntPtr owner);
  public delegate IntPtr SwigDelegateMgBaseLines_8();
  public delegate int SwigDelegateMgBaseLines_9();
  public delegate void SwigDelegateMgBaseLines_10(int count);
  public delegate void SwigDelegateMgBaseLines_11();
  public delegate void SwigDelegateMgBaseLines_12();
  public delegate void SwigDelegateMgBaseLines_13(IntPtr mat);
  public delegate void SwigDelegateMgBaseLines_14();
  public delegate void SwigDelegateMgBaseLines_15();
  public delegate int SwigDelegateMgBaseLines_16();
  public delegate IntPtr SwigDelegateMgBaseLines_17(int index);
  public delegate void SwigDelegateMgBaseLines_18(int index, IntPtr pt);
  public delegate bool SwigDelegateMgBaseLines_19();
  public delegate bool SwigDelegateMgBaseLines_20();
  public delegate float SwigDelegateMgBaseLines_21(IntPtr pt, float tol, IntPtr res);
  public delegate bool SwigDelegateMgBaseLines_22(IntPtr rect);
  public delegate bool SwigDelegateMgBaseLines_23(int mode, IntPtr gs, IntPtr ctx, int segment);
  public delegate bool SwigDelegateMgBaseLines_24(IntPtr s);
  public delegate bool SwigDelegateMgBaseLines_25(IntPtr factory, IntPtr s);
  public delegate int SwigDelegateMgBaseLines_26();
  public delegate IntPtr SwigDelegateMgBaseLines_27(int index);
  public delegate bool SwigDelegateMgBaseLines_28(int index, IntPtr pt, float tol);
  public delegate bool SwigDelegateMgBaseLines_29(int index);
  public delegate int SwigDelegateMgBaseLines_30(int index);
  public delegate bool SwigDelegateMgBaseLines_31(IntPtr vec, int segment);
  public delegate void SwigDelegateMgBaseLines_32(int bit, bool on);

  private SwigDelegateMgBaseLines_0 swigDelegate0;
  private SwigDelegateMgBaseLines_1 swigDelegate1;
  private SwigDelegateMgBaseLines_2 swigDelegate2;
  private SwigDelegateMgBaseLines_3 swigDelegate3;
  private SwigDelegateMgBaseLines_4 swigDelegate4;
  private SwigDelegateMgBaseLines_5 swigDelegate5;
  private SwigDelegateMgBaseLines_6 swigDelegate6;
  private SwigDelegateMgBaseLines_7 swigDelegate7;
  private SwigDelegateMgBaseLines_8 swigDelegate8;
  private SwigDelegateMgBaseLines_9 swigDelegate9;
  private SwigDelegateMgBaseLines_10 swigDelegate10;
  private SwigDelegateMgBaseLines_11 swigDelegate11;
  private SwigDelegateMgBaseLines_12 swigDelegate12;
  private SwigDelegateMgBaseLines_13 swigDelegate13;
  private SwigDelegateMgBaseLines_14 swigDelegate14;
  private SwigDelegateMgBaseLines_15 swigDelegate15;
  private SwigDelegateMgBaseLines_16 swigDelegate16;
  private SwigDelegateMgBaseLines_17 swigDelegate17;
  private SwigDelegateMgBaseLines_18 swigDelegate18;
  private SwigDelegateMgBaseLines_19 swigDelegate19;
  private SwigDelegateMgBaseLines_20 swigDelegate20;
  private SwigDelegateMgBaseLines_21 swigDelegate21;
  private SwigDelegateMgBaseLines_22 swigDelegate22;
  private SwigDelegateMgBaseLines_23 swigDelegate23;
  private SwigDelegateMgBaseLines_24 swigDelegate24;
  private SwigDelegateMgBaseLines_25 swigDelegate25;
  private SwigDelegateMgBaseLines_26 swigDelegate26;
  private SwigDelegateMgBaseLines_27 swigDelegate27;
  private SwigDelegateMgBaseLines_28 swigDelegate28;
  private SwigDelegateMgBaseLines_29 swigDelegate29;
  private SwigDelegateMgBaseLines_30 swigDelegate30;
  private SwigDelegateMgBaseLines_31 swigDelegate31;
  private SwigDelegateMgBaseLines_32 swigDelegate32;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(MgObject) };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] {  };
  private static Type[] swigMethodTypes4 = new Type[] { typeof(MgObject) };
  private static Type[] swigMethodTypes5 = new Type[] {  };
  private static Type[] swigMethodTypes6 = new Type[] { typeof(int) };
  private static Type[] swigMethodTypes7 = new Type[] { typeof(MgShape) };
  private static Type[] swigMethodTypes8 = new Type[] {  };
  private static Type[] swigMethodTypes9 = new Type[] {  };
  private static Type[] swigMethodTypes10 = new Type[] { typeof(int) };
  private static Type[] swigMethodTypes11 = new Type[] {  };
  private static Type[] swigMethodTypes12 = new Type[] {  };
  private static Type[] swigMethodTypes13 = new Type[] { typeof(Matrix2d) };
  private static Type[] swigMethodTypes14 = new Type[] {  };
  private static Type[] swigMethodTypes15 = new Type[] {  };
  private static Type[] swigMethodTypes16 = new Type[] {  };
  private static Type[] swigMethodTypes17 = new Type[] { typeof(int) };
  private static Type[] swigMethodTypes18 = new Type[] { typeof(int), typeof(Point2d) };
  private static Type[] swigMethodTypes19 = new Type[] {  };
  private static Type[] swigMethodTypes20 = new Type[] {  };
  private static Type[] swigMethodTypes21 = new Type[] { typeof(Point2d), typeof(float), typeof(MgHitResult) };
  private static Type[] swigMethodTypes22 = new Type[] { typeof(Box2d) };
  private static Type[] swigMethodTypes23 = new Type[] { typeof(int), typeof(GiGraphics), typeof(GiContext), typeof(int) };
  private static Type[] swigMethodTypes24 = new Type[] { typeof(MgStorage) };
  private static Type[] swigMethodTypes25 = new Type[] { typeof(MgShapeFactory), typeof(MgStorage) };
  private static Type[] swigMethodTypes26 = new Type[] {  };
  private static Type[] swigMethodTypes27 = new Type[] { typeof(int) };
  private static Type[] swigMethodTypes28 = new Type[] { typeof(int), typeof(Point2d), typeof(float) };
  private static Type[] swigMethodTypes29 = new Type[] { typeof(int) };
  private static Type[] swigMethodTypes30 = new Type[] { typeof(int) };
  private static Type[] swigMethodTypes31 = new Type[] { typeof(Vector2d), typeof(int) };
  private static Type[] swigMethodTypes32 = new Type[] { typeof(MgShapeBit), typeof(bool) };
}

}
