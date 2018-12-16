namespace CharmPointerVSTO
{
    partial class SettingsRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SettingsRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.groupCharmPointer = this.Factory.CreateRibbonGroup();
            this.toggleButtonEnabled = this.Factory.CreateRibbonToggleButton();
            this.editBoxShowVelocityThreshold = this.Factory.CreateRibbonEditBox();
            this.editBoxHideVelocityThreshold = this.Factory.CreateRibbonEditBox();
            this.editBoxDuration = this.Factory.CreateRibbonEditBox();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.tab1.SuspendLayout();
            this.groupCharmPointer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabSlideShow";
            this.tab1.Groups.Add(this.groupCharmPointer);
            this.tab1.Label = "TabSlideShow";
            this.tab1.Name = "tab1";
            // 
            // groupCharmPointer
            // 
            this.groupCharmPointer.Items.Add(this.toggleButtonEnabled);
            this.groupCharmPointer.Items.Add(this.separator1);
            this.groupCharmPointer.Items.Add(this.editBoxShowVelocityThreshold);
            this.groupCharmPointer.Items.Add(this.editBoxHideVelocityThreshold);
            this.groupCharmPointer.Items.Add(this.editBoxDuration);
            this.groupCharmPointer.Label = "Charm Pointer";
            this.groupCharmPointer.Name = "groupCharmPointer";
            // 
            // toggleButtonEnabled
            // 
            this.toggleButtonEnabled.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.toggleButtonEnabled.Label = "Show";
            this.toggleButtonEnabled.Name = "toggleButtonEnabled";
            this.toggleButtonEnabled.OfficeImageId = "HappyFace";
            this.toggleButtonEnabled.ShowImage = true;
            this.toggleButtonEnabled.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.toggleButtonEnabled_Click);
            // 
            // editBoxShowVelocityThreshold
            // 
            this.editBoxShowVelocityThreshold.Label = "Show Vel.";
            this.editBoxShowVelocityThreshold.Name = "editBoxShowVelocityThreshold";
            this.editBoxShowVelocityThreshold.ScreenTip = "Velocity threshold to show [px/s]";
            this.editBoxShowVelocityThreshold.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.editBoxShowVelocityThreshold_TextChanged);
            // 
            // editBoxHideVelocityThreshold
            // 
            this.editBoxHideVelocityThreshold.Label = "Hide Vel.";
            this.editBoxHideVelocityThreshold.Name = "editBoxHideVelocityThreshold";
            this.editBoxHideVelocityThreshold.ScreenTip = "Velocity threshold to hide  [px/s]";
            this.editBoxHideVelocityThreshold.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.editBoxHideVelocityThreshold_TextChanged);
            // 
            // editBoxDuration
            // 
            this.editBoxDuration.Label = "Duration";
            this.editBoxDuration.Name = "editBoxDuration";
            this.editBoxDuration.ScreenTip = "Duration time to be hidden [s]";
            this.editBoxDuration.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.editBoxDuration_TextChanged);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // SettingsRibbon
            // 
            this.Name = "SettingsRibbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.SettingsRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.groupCharmPointer.ResumeLayout(false);
            this.groupCharmPointer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupCharmPointer;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButtonEnabled;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBoxShowVelocityThreshold;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBoxHideVelocityThreshold;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBoxDuration;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
    }

    partial class ThisRibbonCollection
    {
        internal SettingsRibbon SettingsRibbon
        {
            get { return this.GetRibbon<SettingsRibbon>(); }
        }
    }
}
