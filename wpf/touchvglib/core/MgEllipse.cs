//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace touchvg.core {

public class MgEllipse : MgBaseRect {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MgEllipse(global::System.IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgEllipse_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MgEllipse obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgEllipse() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgEllipse(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MgEllipse() : this(touchvgPINVOKE.new_MgEllipse(), true) {
  }

  public static MgEllipse create() {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgEllipse_create();
    MgEllipse ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgEllipse(cPtr, false);
    return ret;
  }

  public new static int Type() {
    int ret = touchvgPINVOKE.MgEllipse_Type();
    return ret;
  }

  public static MgEllipse cast(MgBaseShape obj) {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgEllipse_cast(MgBaseShape.getCPtr(obj));
    MgEllipse ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgEllipse(cPtr, false);
    return ret;
  }

  public static MgEllipse fromHandle(int h) {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgEllipse_fromHandle(h);
    MgEllipse ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgEllipse(cPtr, false);
    return ret;
  }

  public override MgObject clone() {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgEllipse_clone(swigCPtr);
    MgObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgObject(cPtr, false);
    return ret;
  }

  public override void copy(MgObject src) {
    touchvgPINVOKE.MgEllipse_copy(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void release() {
    touchvgPINVOKE.MgEllipse_release(swigCPtr);
  }

  public override bool equals(MgObject src) {
    bool ret = touchvgPINVOKE.MgEllipse_equals(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getType() {
    int ret = touchvgPINVOKE.MgEllipse_getType(swigCPtr);
    return ret;
  }

  public override bool isKindOf(int type) {
    bool ret = touchvgPINVOKE.MgEllipse_isKindOf(swigCPtr, type);
    return ret;
  }

  public override Box2d getExtent() {
    Box2d ret = new Box2d(touchvgPINVOKE.MgEllipse_getExtent(swigCPtr), true);
    return ret;
  }

  public override void update() {
    touchvgPINVOKE.MgEllipse_update(swigCPtr);
  }

  public override void transform(Matrix2d mat) {
    touchvgPINVOKE.MgEllipse_transform(swigCPtr, Matrix2d.getCPtr(mat));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void clear() {
    touchvgPINVOKE.MgEllipse_clear(swigCPtr);
  }

  public override void clearCachedData() {
    touchvgPINVOKE.MgEllipse_clearCachedData(swigCPtr);
  }

  public override int getPointCount() {
    int ret = touchvgPINVOKE.MgEllipse_getPointCount(swigCPtr);
    return ret;
  }

  public override Point2d getPoint(int index) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgEllipse_getPoint(swigCPtr, index), true);
    return ret;
  }

  public override void setPoint(int index, Point2d pt) {
    touchvgPINVOKE.MgEllipse_setPoint(swigCPtr, index, Point2d.getCPtr(pt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool isClosed() {
    bool ret = touchvgPINVOKE.MgEllipse_isClosed(swigCPtr);
    return ret;
  }

  public override bool hitTestBox(Box2d rect) {
    bool ret = touchvgPINVOKE.MgEllipse_hitTestBox(swigCPtr, Box2d.getCPtr(rect));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool draw(int mode, GiGraphics gs, GiContext ctx, int segment) {
    bool ret = touchvgPINVOKE.MgEllipse_draw(swigCPtr, mode, GiGraphics.getCPtr(gs), GiContext.getCPtr(ctx), segment);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void output(MgPath path) {
    touchvgPINVOKE.MgEllipse_output(swigCPtr, MgPath.getCPtr(path));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool save(MgStorage s) {
    bool ret = touchvgPINVOKE.MgEllipse_save(swigCPtr, MgStorage.getCPtr(s));
    return ret;
  }

  public override bool load(MgShapeFactory factory, MgStorage s) {
    bool ret = touchvgPINVOKE.MgEllipse_load(swigCPtr, MgShapeFactory.getCPtr(factory), MgStorage.getCPtr(s));
    return ret;
  }

  public override int getHandleCount() {
    int ret = touchvgPINVOKE.MgEllipse_getHandleCount(swigCPtr);
    return ret;
  }

  public override Point2d getHandlePoint(int index) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgEllipse_getHandlePoint(swigCPtr, index), true);
    return ret;
  }

  public override bool setHandlePoint(int index, Point2d pt, float tol) {
    bool ret = touchvgPINVOKE.MgEllipse_setHandlePoint(swigCPtr, index, Point2d.getCPtr(pt), tol);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool isHandleFixed(int index) {
    bool ret = touchvgPINVOKE.MgEllipse_isHandleFixed(swigCPtr, index);
    return ret;
  }

  public override int getHandleType(int index) {
    int ret = touchvgPINVOKE.MgEllipse_getHandleType(swigCPtr, index);
    return ret;
  }

  public override bool offset(Vector2d vec, int segment) {
    bool ret = touchvgPINVOKE.MgEllipse_offset(swigCPtr, Vector2d.getCPtr(vec), segment);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override float hitTest(Point2d pt, float tol, MgHitResult res) {
    float ret = touchvgPINVOKE.MgEllipse_hitTest(swigCPtr, Point2d.getCPtr(pt), tol, MgHitResult.getCPtr(res));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getRadiusX() {
    float ret = touchvgPINVOKE.MgEllipse_getRadiusX(swigCPtr);
    return ret;
  }

  public float getRadiusY() {
    float ret = touchvgPINVOKE.MgEllipse_getRadiusY(swigCPtr);
    return ret;
  }

  public void setRadius(float rx, float ry) {
    touchvgPINVOKE.MgEllipse_setRadius__SWIG_0(swigCPtr, rx, ry);
  }

  public void setRadius(float rx) {
    touchvgPINVOKE.MgEllipse_setRadius__SWIG_1(swigCPtr, rx);
  }

  public bool setCircle(Point2d center, float radius) {
    bool ret = touchvgPINVOKE.MgEllipse_setCircle(swigCPtr, Point2d.getCPtr(center), radius);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setCircle2P(Point2d start, Point2d end) {
    bool ret = touchvgPINVOKE.MgEllipse_setCircle2P(swigCPtr, Point2d.getCPtr(start), Point2d.getCPtr(end));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setCircle3P(Point2d start, Point2d point, Point2d end) {
    bool ret = touchvgPINVOKE.MgEllipse_setCircle3P(swigCPtr, Point2d.getCPtr(start), Point2d.getCPtr(point), Point2d.getCPtr(end));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isCircle() {
    bool ret = touchvgPINVOKE.MgEllipse_isCircle__SWIG_0(swigCPtr);
    return ret;
  }

  public static bool isCircle(MgBaseShape sp) {
    bool ret = touchvgPINVOKE.MgEllipse_isCircle__SWIG_1(MgBaseShape.getCPtr(sp));
    return ret;
  }

  public static int crossCircle(Point2d pt1, Point2d pt2, MgBaseShape sp1, MgBaseShape sp2, Point2d hitpt) {
    int ret = touchvgPINVOKE.MgEllipse_crossCircle__SWIG_0(Point2d.getCPtr(pt1), Point2d.getCPtr(pt2), MgBaseShape.getCPtr(sp1), MgBaseShape.getCPtr(sp2), Point2d.getCPtr(hitpt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int crossCircle(Point2d pt1, Point2d pt2, MgBaseShape sp) {
    int ret = touchvgPINVOKE.MgEllipse_crossCircle__SWIG_1(Point2d.getCPtr(pt1), Point2d.getCPtr(pt2), MgBaseShape.getCPtr(sp));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
