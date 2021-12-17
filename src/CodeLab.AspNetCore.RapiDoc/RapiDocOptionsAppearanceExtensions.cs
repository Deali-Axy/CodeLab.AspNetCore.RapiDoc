namespace CodeLab.AspNetCore.RapiDoc {
    /// <summary>
    /// 外观选项配置扩展类
    /// </summary>
    public static class RapiDocOptionsAppearanceExtensions {
        /// <summary>
        /// RapiDoc 主题：light、dark
        /// </summary>
        /// <param name="options"></param>
        /// <param name="theme"></param>
        public static void Theme(this RapiDocOptions options, string theme) {
            options.ConfigObject.Theme = theme;
        }

        /// <summary>
        /// RapiDoc 渲染模式：read、focused
        /// </summary>
        /// <param name="options"></param>
        /// <param name="renderStyle"></param>
        public static void RenderStyle(this RapiDocOptions options, string renderStyle) {
            options.ConfigObject.RenderStyle = renderStyle;
        }

        /// <summary>
        /// RapiDoc 呈现模式：tree、table
        /// </summary>
        /// <param name="options"></param>
        /// <param name="schemaStyle"></param>
        public static void SchemaStyle(this RapiDocOptions options, string schemaStyle) {
            options.ConfigObject.SchemaStyle = schemaStyle;
        }
    }
}