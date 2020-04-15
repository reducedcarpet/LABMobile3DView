namespace net.firestaff.mcp.baselab.util
{

    public class PropPagerConstants
    {
        /*
        int CW = 1;
        int CCW = -1;
        string PATH_DIRECTION = "net.firestaff.mcp.doublestafflab.PATH_DIRECTION";
        string PROP_DIRECTION = "net.firestaff.mcp.doublestafflab.PROP_DIRECTION";
        string PATH_SPEED = "net.firestaff.mcp.doublestafflab.PATH_SPEED";
        string PROP_SPEED = "net.firestaff.mcp.doublestafflab.PROP_SPEED";
        string PATH_SIZE = "net.firestaff.mcp.doublestafflab.PATH_SIZE";
        string PATH_ROTATION = "net.firestaff.mcp.doublestafflab.PATH_ROTATION";
        string PATH_ANGLE_MODIFIER = "net.firestaff.mcp.doublestafflab.PATH_ANGLE_MODIFIER";
        string PROP_ANGLE_MODIFIER = "net.firestaff.mcp.doublestafflab.PROP_ANGLE_MODIFIER";
        string SHAPE = "net.firestaff.mcp.doublestafflab.SHAPE";
        string LEFT_SHAPE = "net.firestaff.mcp.doublestafflab.LEFT_SHAPE";
        string LEFT_PATH_DIRECTION = "net.firestaff.mcp.doublestafflab.LEFT_PATH_DIRECTION";
        string LEFT_PROP_DIRECTION = "net.firestaff.mcp.doublestafflab.LEFT_PROP_DIRECTION";
        string LEFT_PATH_SPEED = "net.firestaff.mcp.doublestafflab.LEFT_PATH_SPEED";
        string LEFT_PROP_SPEED = "net.firestaff.mcp.doublestafflab.LEFT_PROP_SPEED";
        string LEFT_PATH_SIZE = "net.firestaff.mcp.doublestafflab.LEFT_PATH_SIZE";
        string LEFT_PATH_ROTATION = "net.firestaff.mcp.doublestafflab.LEFT_PATH_ROTATION";
        string LEFT_PATH_ANGLE_MODIFIER = "net.firestaff.mcp.doublestafflab.LEFT_PATH_ANGLE_MODIFIER";
        string LEFT_PROP_ANGLE_MODIFIER = "net.firestaff.mcp.doublestafflab.LEFT_PROP_ANGLE_MODIFIER";
        string LEFT_X_ADJ = "net.firestaff.mcp.doublestafflab.LEFT_X_ADJ";
        string LEFT_Y_ADJ = "net.firestaff.mcp.doublestafflab.LEFT_Y_ADJ";
        string RIGHT_X_ADJ = "net.firestaff.mcp.doublestafflab.RIGHT_X_ADJ";
        string RIGHT_Y_ADJ = "net.firestaff.mcp.doublestafflab.RIGHT_Y_ADJ";
        string LEFT_X_PIVOT = "net.firestaff.mcp.doublestafflab.LEFT_X_PIVOT";
        string RIGHT_X_PIVOT = "net.firestaff.mcp.doublestafflab.RIGHT_X_PIVOT";
        string RIGHT_COMPLEX_SHAPE = "net.firestaff.mcp.doublestafflab.RIGHT_COMPLEX_SHAPE";
        string LEFT_COMPLEX_SHAPE = "net.firestaff.mcp.doublestafflab.LEFT_COMPLEX_SHAPE";

        string RIGHT_GHOST_STAFF = "net.firestaff.mcp.doublestafflab.RIGHT_GHOST_STAFF";
        string LEFT_GHOST_STAFF = "net.firestaff.mcp.doublestafflab.LEFT_GHOST_STAFF";

        string RIGHT_SPEED_CONTROL = "net.firestaff.mcp.doublestafflab.RIGHT_SPEED_CONTROL";
        string LEFT_SPEED_CONTROL = "net.firestaff.mcp.doublestafflab.LEFT_SPEED_CONTROL";
        string RIGHT_SPEED_CONTROL_MODIFIER = "net.firestaff.mcp.doublestafflab.RIGHT_SPEED_CONTROL_MODIFIER";
        string LEFT_SPEED_CONTROL_MODIFIER = "net.firestaff.mcp.doublestafflab.LEFT_SPEED_CONTROL_MODIFIER";

        string RIGHT_SPEED_UPPER = "net.firestaff.mcp.doublestafflab.RIGHT_SPEED_UPPER";
        string RIGHT_SPEED_LOWER = "net.firestaff.mcp.doublestafflab.RIGHT_SPEED_LOWER";
        string LEFT_SPEED_UPPER = "net.firestaff.mcp.doublestafflab.LEFT_SPEED_UPPER";
        string LEFT_SPEED_LOWER = "net.firestaff.mcp.doublestafflab.LEFT_SPEED_LOWER";

        string RIGHT_DIRECTION_CONTROL = "net.firestaff.mcp.doublestafflab.RIGHT_DIRECTION_CONTROL";
        string LEFT_DIRECTION_CONTROL = "net.firestaff.mcp.doublestafflab.LEFT_DIRECTION_CONTROL";
        string RIGHT_DIRECTION_CONTROL_MODIFIER = "net.firestaff.mcp.doublestafflab.RIGHT_DIRECTION_CONTROL_MODIFIER";
        string LEFT_DIRECTION_CONTROL_MODIFIER = "net.firestaff.mcp.doublestafflab.LEFT_DIRECTION_CONTROL_MODIFIER";

        string RIGHT_Z_SHAPE = "net.firestaff.mcp.doublestafflab.RIGHT_Z_SHAPE";
        string LEFT_Z_SHAPE = "net.firestaff.mcp.doublestafflab.LEFT_Z_SHAPE";
        string RIGHT_USE_3D = "net.firestaff.mcp.doublestafflab.RIGHT_USE_3D";
        string LEFT_USE_3D = "net.firestaff.mcp.doublestafflab.LEFT_USE_3D";
        string RIGHT_MOD_3D = "net.firestaff.mcp.doublestafflab.RIGHT_MOD_3D";
        string LEFT_MOD_3D = "net.firestaff.mcp.doublestafflab.LEFT_MOD_3D";

        string LEFT_FLIP_3D = "net.firestaff.mcp.doublestafflab.LEFT_FLIP_3D";
        string LEFT_TWIST_3D = "net.firestaff.mcp.doublestafflab.LEFT_TWIST_3D";
        string RIGHT_FLIP_3D = "net.firestaff.mcp.doublestafflab.RIGHT_FLIP_3D";
        string RIGHT_TWIST_3D = "net.firestaff.mcp.doublestafflab.RIGHT_TWIST_3D";

        string RIGHT_USE_GRAVITY = "net.firestaff.mcp.doublestafflab.RIGHT_USE_GRAVITY";
        string LEFT_USE_GRAVITY = "net.firestaff.mcp.doublestafflab.LEFT_USE_GRAVITY";
        string RIGHT_USE_PENDULUMS = "net.firestaff.mcp.doublestafflab.RIGHT_USE_PENDULUMS";
        string LEFT_USE_PENDULUMS = "net.firestaff.mcp.doublestafflab.LEFT_USE_PENDULUMS";

        string USE_L2 = "net.firestaff.mcp.poilab.USE_L2";
        string USE_R2 = "net.firestaff.mcp.poilab.USE_R2";

        string R2_PROP_DIRECTION = "net.firestaff.mcp.doublestafflab.R2_PROP_DIRECTION";
        string R2_PROP_SPEED = "net.firestaff.mcp.doublestafflab.R2_PROP_SPEED";
        string R2_PIVOT_X = "net.firestaff.mcp.doublestafflab.R2_PIVOT_X";
        string R2_PROP_ANGLE_MODIFIER = "net.firestaff.mcp.doublestafflab.R2_PROP_ANGLE_MODIFIER";
        string R2_SPEED_CONTROL = "net.firestaff.mcp.doublestafflab.R2_SPEED_CONTROL";
        string R2_SPEED_CONTROL_MODIFIER = "net.firestaff.mcp.doublestafflab.R2_SPEED_CONTROL_MODIFIER";
        string R2_DIRECTION_CONTROL = "net.firestaff.mcp.doublestafflab.R2_DIRECTION_CONTROL";
        string R2_DIRECTION_CONTROL_MODIFIER = "net.firestaff.mcp.doublestafflab.R2_DIRECTION_CONTROL_MODIFIER";

        string L2_PROP_DIRECTION = "net.firestaff.mcp.doublestafflab.L2_PROP_DIRECTION";
        string L2_PROP_SPEED = "net.firestaff.mcp.doublestafflab.L2_PROP_SPEED";
        string L2_PIVOT_X = "net.firestaff.mcp.doublestafflab.L2_PIVOT_X";
        string L2_PROP_ANGLE_MODIFIER = "net.firestaff.mcp.doublestafflab.L2_PROP_ANGLE_MODIFIER";
        string L2_SPEED_CONTROL = "net.firestaff.mcp.doublestafflab.L2_SPEED_CONTROL";
        string L2_SPEED_CONTROL_MODIFIER = "net.firestaff.mcp.doublestafflab.L2_SPEED_CONTROL_MODIFIER";
        string L2_DIRECTION_CONTROL = "net.firestaff.mcp.doublestafflab.L2_DIRECTION_CONTROL";
        string L2_DIRECTION_CONTROL_MODIFIER = "net.firestaff.mcp.doublestafflab.L2_DIRECTION_CONTROL_MODIFIER";

        string STAFF_TYPE = "net.firestaff.mcp.doublestafflab.STAFF_TYPE";
        string PROP_TYPE = "net.firestaff.mcp.poilab.PROP_TYPE";

        string PROP_TYPE_PREFERENCE = "net.firestaff.mcp.poilab.PROP_TYPE_PREFERENCE";
        string VTG_PREFERENCE = "net.firestaff.mcp.doublestafflab.VTG_PREFERENCE";
        string POI_TYPE_PREFERENCE = "net.firestaff.mcp.doublestafflab.POI_TYPE_PREFERENCE";
        string HOOP_TYPE_PREFERENCE = "net.firestaff.mcp.doublestafflab.HOOP_TYPE_PREFERENCE";
        /**/
    }
}
