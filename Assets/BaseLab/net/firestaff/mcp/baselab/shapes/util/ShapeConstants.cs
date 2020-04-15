using System.Collections.Generic;
using System.Collections; 

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.complex;
using net.firestaff.mcp.baselab.shapes.gridtracing;
using net.firestaff.mcp.baselab.shapes.paused;
using net.firestaff.mcp.baselab.shapes.secondorder;
using net.firestaff.mcp.baselab.shapes.weird;


namespace net.firestaff.mcp.baselab.shapes.util
{

    public class ShapeConstants {

        public static Shape POINT = new Dot();

        public static Shape CIRCLE = new Circle();
        public static Shape OVAL = new Oval();
        public static Shape SQUARE = new Square();

        public static Shape LINE = new Line();
        public static Shape VERTICAL_LINE = new Line(true);
        public static Shape HORIZONTAL_LINE = new Line();
        public static Shape PLUS_CORNER = new PlusCorner();
        public static Shape PLUS = new Plus();
        public static Shape PLUS_HALF = new PlusHalf();
        public static Shape PLUS_HALF_CAP = new PlusHalfCAP();

        public static Shape ULTIMATE = new UltimateComplexShape();

        public static Shape CORNER = new CornerComplexShape();

        public static Shape HYPOCYCLOID = new HypocycloidReal();
        public static Shape HYPOCYCLOID_FAKE = new HypocycloidFake();
        public static Shape HYPOCYCLOID_ONE = new HypocycloidOne();
        public static Shape HYPOCYCLOID_TWO = new HypocycloidTwo();

        public static Shape EPICYCLOID = new Epicycloid();
        public static Shape EPICYCLOID_ONE = new EpicycloidOne();
        public static Shape EPICYCLOID_TWO = new EpicycloidTwo();
        public static Shape EPICYCLOID_THREE = new EpicycloidThree();
        public static Shape EPICYCLOID_FIVE = new EpicycloidFive();
        public static Shape EPICYCLOID_SIX = new EpicycloidSix();
        public static Shape EPICYCLOID_SEVEN = new EpicycloidSeven();
        public static Shape EPICYCLOID_EIGHT = new EpicycloidEight();

        public static Shape EPITROCHOID = new Epitrochoid();
        public static Shape EPITROCHOID_ONE = new EpitrochoidOne();
        public static Shape EPITROCHOID_TWO = new EpitrochoidTwo();
        public static Shape EPITROCHOID_THREE = new EpitrochoidThree();
        public static Shape EPITROCHOID_FIVE = new EpitrochoidFive();
        public static Shape EPITROCHOID_SIX = new EpitrochoidSix();
        public static Shape EPITROCHOID_SEVEN = new EpitrochoidSeven();
        public static Shape EPITROCHOID_EIGHT = new EpitrochoidEight();

        public static Shape HYPOTROCHOID = new Hypotrochoid();
        public static Shape HYPOTROCHOID_ONE = new HypotrochoidOne();
        public static Shape HYPOTROCHOID_TWO = new HypotrochoidTwo();
        public static Shape HYPOTROCHOID_THREE = new HypotrochoidThree();
        public static Shape HYPOTROCHOID_FIVE = new HypotrochoidFive();
        public static Shape HYPOTROCHOID_SIX = new HypotrochoidSix();
        public static Shape HYPOTROCHOID_SEVEN = new HypotrochoidSeven();
        public static Shape HYPOTROCHOID_EIGHT = new HypotrochoidEight();

        public static Shape TRIANGLE = new HypocycloidTriangle();
        public static Shape PENTAGON = new HypocycloidFive();
        public static Shape OCTAGON = new HypocycloidSix();

        public static Shape HYPOCYCLOID_SEVEN = new HypocycloidSeven();
        public static Shape HYPOCYCLOID_EIGHT = new HypocycloidEight();

        public static Shape H_LINE = new HLine();
        public static Shape H_LINE_FIG8 = new HLineFig8();
        public static Shape H_CURVE = new HCurve();
        public static Shape H_CURVE_FIG8 = new HCurveFig8();
        public static Shape H_CIRCLE = new HCircle();
        public static Shape H_CIRCLE_FIG8 = new HCircleFig8();

        public static Shape PAUSED_FULL_CIRCLE = new PausedFullComplexShape();
        public static Shape PAUSED_HALF_CIRCLE = new PausedHalfComplexShape();
        public static Shape PAUSED_QUARTER_CIRCLE = new PausedQuarterComplexShape();

        //public static final public static Shape PAUSED_FULL_CIRCLE = new PausedFullComplexpublic static Shape();
        public static Shape PAUSED_HALF_CAP = new PausedHalfCapComplexShape();
        //public static final Shape PAUSED_QUARTER_CIRCLE = new PausedQuarterComplexShape();

        public static Shape FULL_CIRCLE = new FullComplexShape();

        public static Shape HALF_CIRCLE_HORIZONTAL_TOP = new HalfHorizontalTopComplexShape();
        public static Shape HALF_CIRCLE_HORIZONTAL_BOTTOM = new HalfHorizontalBottomComplexShape();
        public static Shape HALF_CIRCLE_VERTICAL_LEFT = new HalfVerticalLeftComplexShape();
        public static Shape HALF_CIRCLE_VERTICAL_RIGHT = new HalfVerticalRightComplexShape();

        public static Shape LISSAJOUS_FIGURE = new LissajousCurve();
        public static Shape FIGURE_OF_EIGHT = new FigureEight();
        public static Shape FIGURE_OF_EIGHT_COMPLEX_SHAPE = new FigureEightComplexShape();
        public static Shape FIGURE_OF_EIGHT_BROKEN_COMPLEX_SHAPE = new FigureEightBrokenComplexShape();
        public static Shape FIGURE_OF_EIGHT_CAP_HIGH_COMPLEX_SHAPE = new FigureEightCAPOneComplexShape();
        public static Shape FIGURE_OF_EIGHT_CAP_LOW_COMPLEX_SHAPE = new FigureEightCAPTwoComplexShape();

        public static Shape QUARTERS_TOP_LEFT = new QuarterTopLeftComplexShape();
        public static Shape QUARTERS_TOP_RIGHT = new QuarterTopRightComplexShape();
        public static Shape QUARTERS_BOTTOM_LEFT = new QuarterBottomLeftComplexShape();
        public static Shape QUARTERS_BOTTOM_RIGHT = new QuarterBottomRightComplexShape();

        public static Shape TRANSLATED_HALF_COMPLEX_SHAPE = new TranslatedHalfComplexShape();
        public static Shape TRANSLATED_QUARTER_COMPLEX_SHAPE = new TranslatedQuarterComplexShape();
        public static Shape TRANSLATED_HALF_BROKEN_COMPLEX_SHAPE = new TranslatedHalfBrokenComplexShape();
        public static Shape TRANSLATED_QUARTER_BROKEN_COMPLEX_SHAPE = new TranslatedQuarterBrokenComplexShape();
        public static Shape TRANSLATED_QUARTER_HALFED_COMPLEX_SHAPE = new TranslatedQuarterHalfedComplexShape();
        public static Shape TRANSLATED_DIAGONAL_COMPLEX_SHAPE = new TranslatedDiagonalComplexShape();
        public static Shape TRANSLATED_CORNER_COMPLEX_SHAPE = new TranslatedCornerComplexShape();

        public static ComplexShape SQUISH_X_COMPLEX_SHAPE = new SquishXComplexShape();
        public static ComplexShape SQUISH_Y_COMPLEX_SHAPE = new SquishYComplexShape();
        public static ComplexShape QUARTER_STEPPED_COMPLEX_SHAPE = new QuarterSteppedComplexShape();
        public static ComplexShape STEPPED_QUARTER_CAP_COMPLEX_SHAPE = new SteppedQuarterCAPComplexShape();
        public static ComplexShape DOUBLE_STEPPED_QUARTER_CAP_COMPLEX_SHAPE = new DoubleSteppedQuarterCAPComplexShape();

        public static ComplexShape GT_PEANUT_COMPLEX_SHAPE = new GTPeanutComplexShape();
        public static ComplexShape GT_PLUS_KNOT_COMPLEX_SHAPE = new GTPlusKnotComplexShape();
        public static ComplexShape GT_HALF_PLUS_KNOT_COMPLEX_SHAPE = new GTHalfPlusComplexShape();
        public static ComplexShape GT_SWITCHBACK_KNOT_COMPLEX_SHAPE = new GTSwitchbackComplexShape();
        public static ComplexShape GT_SWITCHBACK_PLUS_KNOT_COMPLEX_SHAPE = new GTSwitchbackPlusComplexShape();
        public static ComplexShape GT_THREE_BEAT_KNOT_COMPLEX_SHAPE = new GTThreeBeatKnotComplexShape();

        public static List<Shape> shapes = new List<Shape>();

        static ShapeConstants()
        {
            shapes.Add(GT_PEANUT_COMPLEX_SHAPE);
            shapes.Add(GT_PLUS_KNOT_COMPLEX_SHAPE);
            shapes.Add(GT_HALF_PLUS_KNOT_COMPLEX_SHAPE);
            shapes.Add(GT_SWITCHBACK_KNOT_COMPLEX_SHAPE);
            shapes.Add(GT_SWITCHBACK_PLUS_KNOT_COMPLEX_SHAPE);
            shapes.Add(GT_THREE_BEAT_KNOT_COMPLEX_SHAPE);

            shapes.Add(SQUISH_X_COMPLEX_SHAPE);
            shapes.Add(SQUISH_Y_COMPLEX_SHAPE);
            shapes.Add(QUARTER_STEPPED_COMPLEX_SHAPE);
            shapes.Add(STEPPED_QUARTER_CAP_COMPLEX_SHAPE);
            shapes.Add(DOUBLE_STEPPED_QUARTER_CAP_COMPLEX_SHAPE);

            shapes.Add(TRANSLATED_HALF_COMPLEX_SHAPE);
            shapes.Add(TRANSLATED_QUARTER_COMPLEX_SHAPE);
            shapes.Add(TRANSLATED_HALF_BROKEN_COMPLEX_SHAPE);
            shapes.Add(TRANSLATED_QUARTER_BROKEN_COMPLEX_SHAPE);
            shapes.Add(TRANSLATED_QUARTER_HALFED_COMPLEX_SHAPE);
            shapes.Add(TRANSLATED_DIAGONAL_COMPLEX_SHAPE);
            shapes.Add(TRANSLATED_CORNER_COMPLEX_SHAPE);

            shapes.Add(PAUSED_FULL_CIRCLE);
            shapes.Add(PAUSED_HALF_CIRCLE);
            shapes.Add(PAUSED_QUARTER_CIRCLE);
            shapes.Add(PAUSED_HALF_CAP);

            shapes.Add(CIRCLE);
            shapes.Add(OVAL);
            shapes.Add(SQUARE);

            shapes.Add(ULTIMATE);

            shapes.Add(LINE);
            shapes.Add(HORIZONTAL_LINE);
            shapes.Add(VERTICAL_LINE);
            shapes.Add(PLUS);
            shapes.Add(PLUS_CORNER);
            shapes.Add(PLUS_HALF);
            shapes.Add(PLUS_HALF_CAP);

            shapes.Add(POINT);

            shapes.Add(H_LINE);
            shapes.Add(H_LINE_FIG8);
            shapes.Add(H_CURVE);
            shapes.Add(H_CURVE_FIG8);
            shapes.Add(H_CIRCLE);
            shapes.Add(H_CIRCLE_FIG8);

            shapes.Add(HYPOCYCLOID);
            shapes.Add(HYPOCYCLOID_FAKE);

            shapes.Add(EPITROCHOID);
            shapes.Add(EPITROCHOID_ONE);
            shapes.Add(EPITROCHOID_TWO);
            shapes.Add(EPITROCHOID_THREE);
            shapes.Add(EPITROCHOID_FIVE);
            shapes.Add(EPITROCHOID_SIX);
            shapes.Add(EPITROCHOID_SEVEN);
            shapes.Add(EPITROCHOID_EIGHT);

            shapes.Add(HYPOTROCHOID);
            shapes.Add(HYPOTROCHOID_ONE);
            shapes.Add(HYPOTROCHOID_TWO);
            shapes.Add(HYPOTROCHOID_THREE);
            shapes.Add(HYPOTROCHOID_FIVE);
            shapes.Add(HYPOTROCHOID_SIX);
            shapes.Add(HYPOTROCHOID_SEVEN);
            shapes.Add(HYPOTROCHOID_EIGHT);

            shapes.Add(EPICYCLOID);
            shapes.Add(EPICYCLOID_ONE);
            shapes.Add(EPICYCLOID_TWO);
            shapes.Add(EPICYCLOID_THREE);
            shapes.Add(EPICYCLOID_FIVE);
            shapes.Add(EPICYCLOID_SIX);
            shapes.Add(EPICYCLOID_SEVEN);
            shapes.Add(EPICYCLOID_EIGHT);

            shapes.Add(HYPOCYCLOID_ONE);
            shapes.Add(HYPOCYCLOID_TWO);
            shapes.Add(TRIANGLE);
            shapes.Add(PENTAGON);
            shapes.Add(OCTAGON);
            shapes.Add(HYPOCYCLOID_SEVEN);
            shapes.Add(HYPOCYCLOID_EIGHT);

            shapes.Add(FULL_CIRCLE);

            shapes.Add(HALF_CIRCLE_HORIZONTAL_TOP);
            shapes.Add(HALF_CIRCLE_HORIZONTAL_BOTTOM);
            shapes.Add(HALF_CIRCLE_VERTICAL_LEFT);
            shapes.Add(HALF_CIRCLE_VERTICAL_RIGHT);

            shapes.Add(FIGURE_OF_EIGHT);
            shapes.Add(FIGURE_OF_EIGHT_COMPLEX_SHAPE);
            shapes.Add(FIGURE_OF_EIGHT_BROKEN_COMPLEX_SHAPE);
            shapes.Add(LISSAJOUS_FIGURE);
            shapes.Add(FIGURE_OF_EIGHT_CAP_HIGH_COMPLEX_SHAPE);
            shapes.Add(FIGURE_OF_EIGHT_CAP_LOW_COMPLEX_SHAPE);

            shapes.Add(QUARTERS_TOP_LEFT);
            shapes.Add(QUARTERS_TOP_RIGHT);
            shapes.Add(QUARTERS_BOTTOM_LEFT);
            shapes.Add(QUARTERS_BOTTOM_RIGHT);

            shapes.Add(CORNER);

        }

    }

}