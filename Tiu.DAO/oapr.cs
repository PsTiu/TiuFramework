// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from oapr on 2013-04-16 16:02:43Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace Tiu.DAO
{
    using System;
    using System.ComponentModel;
    using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
    using DbLinq.Data.Linq;
    using DbLinq.Vendor;
#endif  // MONO_STRICT
    using System.Data.Linq.Mapping;
    using System.Diagnostics;
    using MySql.Data.MySqlClient;


    public partial class Oapr : DataContext
    {

        #region Extensibility Method Declarations
        partial void OnCreated();
        #endregion

        #region constructors

        public Oapr(string connectionString) :
            base(connectionString)
        {
            this.OnCreated();
        }

        public Oapr(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            this.OnCreated();
        }

        public Oapr(IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            this.OnCreated();
        }

        #endregion

        #region tables

        public Table<Attachment> Attachment
        {
            get
            {
                return this.GetTable<Attachment>();
            }
        }

        public Table<FlowDef> FlowDef
        {
            get
            {
                return this.GetTable<FlowDef>();
            }
        }

        public Table<FlownOdeDef> FlownOdeDef
        {
            get
            {
                return this.GetTable<FlownOdeDef>();
            }
        }

        public Table<FlownOderOle> FlownOderOle
        {
            get
            {
                return this.GetTable<FlownOderOle>();
            }
        }

        public Table<FlownOderUnInfo> FlownOderUnInfo
        {
            get
            {
                return this.GetTable<FlownOderUnInfo>();
            }
        }

        public Table<FlowRule> FlowRule
        {
            get
            {
                return this.GetTable<FlowRule>();
            }
        }

        public Table<Production> Production
        {
            get
            {
                return this.GetTable<Production>();
            }
        }

        public Table<ProductionStage> ProductionStage
        {
            get
            {
                return this.GetTable<ProductionStage>();
            }
        }

        public Table<ProductionUserRole> ProductionUserRole
        {
            get
            {
                return this.GetTable<ProductionUserRole>();
            }
        }

        public Table<Requirement> Requirement
        {
            get
            {
                return this.GetTable<Requirement>();
            }
        }

        public Table<RequirementChild> RequirementChild
        {
            get
            {
                return this.GetTable<RequirementChild>();
            }
        }

        public Table<RequirementDetail> RequirementDetail
        {
            get
            {
                return this.GetTable<RequirementDetail>();
            }
        }

        public Table<RequirementsTauS> RequirementsTauS
        {
            get
            {
                return this.GetTable<RequirementsTauS>();
            }
        }

        public Table<Role> Role
        {
            get
            {
                return this.GetTable<Role>();
            }
        }

        public Table<Score> Score
        {
            get
            {
                return this.GetTable<Score>();
            }
        }

        public Table<ScoreDef> ScoreDef
        {
            get
            {
                return this.GetTable<ScoreDef>();
            }
        }

        public Table<Studio> Studio
        {
            get
            {
                return this.GetTable<Studio>();
            }
        }

        #endregion
    }

    #region Start MONO_STRICT
#if MONO_STRICT

	public partial class OApR
	{
		
		public OApR(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
	}
    #region End MONO_STRICT
    #endregion
#else     // MONO_STRICT
    #region constructors

    public partial class Oapr
    {
        public Oapr() : this(new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["oapr"].ToString())) { }

        public Oapr(IDbConnection connection) :
            base(connection, new DbLinq.MySql.MySqlVendor())
        {
            this.OnCreated();
        }

        public Oapr(IDbConnection connection, IVendor sqlDialect) :
            base(connection, sqlDialect)
        {
            this.OnCreated();
        }

        public Oapr(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) :
            base(connection, mappingSource, sqlDialect)
        {
            this.OnCreated();
        }

    #endregion
    }
    #region End Not MONO_STRICT
    #endregion
#endif     // MONO_STRICT
    #endregion

    #region Models

    [Table(Name = "oapr.attachment")]
    public partial class Attachment : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private System.DateTime _createTime;

        private string _desc;

        private int _id;

        private sbyte _isShow;

        private int _requirementID;

        private string _srcName;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnCreateTimeChanged();

        partial void OnCreateTimeChanging(System.DateTime value);

        partial void OnDescChanged();

        partial void OnDescChanging(string value);

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnIsShowChanged();

        partial void OnIsShowChanging(sbyte value);

        partial void OnRequirementIDChanged();

        partial void OnRequirementIDChanging(int value);

        partial void OnSrcNameChanged();

        partial void OnSrcNameChanging(string value);
        #endregion


        public Attachment()
        {
            this.OnCreated();
        }

        [Column(Storage = "_createTime", Name = "CreateTime", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public System.DateTime CreateTime
        {
            get
            {
                return this._createTime;
            }
            set
            {
                if ((_createTime != value))
                {
                    this.OnCreateTimeChanging(value);
                    this.SendPropertyChanging();
                    this._createTime = value;
                    this.SendPropertyChanged("CreateTime");
                    this.OnCreateTimeChanged();
                }
            }
        }

        [Column(Storage = "_desc", Name = "Desc", DbType = "varchar(500)", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Desc
        {
            get
            {
                return this._desc;
            }
            set
            {
                if (((_desc == value)
                            == false))
                {
                    this.OnDescChanging(value);
                    this.SendPropertyChanging();
                    this._desc = value;
                    this.SendPropertyChanged("Desc");
                    this.OnDescChanged();
                }
            }
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_isShow", Name = "IsShow", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsShow
        {
            get
            {
                return this._isShow;
            }
            set
            {
                if ((_isShow != value))
                {
                    this.OnIsShowChanging(value);
                    this.SendPropertyChanging();
                    this._isShow = value;
                    this.SendPropertyChanged("IsShow");
                    this.OnIsShowChanged();
                }
            }
        }

        [Column(Storage = "_requirementID", Name = "RequirementId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int RequirementID
        {
            get
            {
                return this._requirementID;
            }
            set
            {
                if ((_requirementID != value))
                {
                    this.OnRequirementIDChanging(value);
                    this.SendPropertyChanging();
                    this._requirementID = value;
                    this.SendPropertyChanged("RequirementID");
                    this.OnRequirementIDChanged();
                }
            }
        }

        [Column(Storage = "_srcName", Name = "SrcName", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string SrcName
        {
            get
            {
                return this._srcName;
            }
            set
            {
                if (((_srcName == value)
                            == false))
                {
                    this.OnSrcNameChanging(value);
                    this.SendPropertyChanging();
                    this._srcName = value;
                    this.SendPropertyChanged("SrcName");
                    this.OnSrcNameChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.flowdef")]
    public partial class FlowDef : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private string _desc;

        private string _flowID;

        private sbyte _isEnable;

        private string _name;

        private int _seq;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnDescChanged();

        partial void OnDescChanging(string value);

        partial void OnFlowIDChanged();

        partial void OnFlowIDChanging(string value);

        partial void OnIsEnableChanged();

        partial void OnIsEnableChanging(sbyte value);

        partial void OnNameChanged();

        partial void OnNameChanging(string value);

        partial void OnSeqChanged();

        partial void OnSeqChanging(int value);
        #endregion


        public FlowDef()
        {
            this.OnCreated();
        }

        [Column(Storage = "_desc", Name = "Desc", DbType = "text", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Desc
        {
            get
            {
                return this._desc;
            }
            set
            {
                if (((_desc == value)
                            == false))
                {
                    this.OnDescChanging(value);
                    this.SendPropertyChanging();
                    this._desc = value;
                    this.SendPropertyChanged("Desc");
                    this.OnDescChanged();
                }
            }
        }

        [Column(Storage = "_flowID", Name = "FlowId", DbType = "varchar(20)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string FlowID
        {
            get
            {
                return this._flowID;
            }
            set
            {
                if (((_flowID == value)
                            == false))
                {
                    this.OnFlowIDChanging(value);
                    this.SendPropertyChanging();
                    this._flowID = value;
                    this.SendPropertyChanged("FlowID");
                    this.OnFlowIDChanged();
                }
            }
        }

        [Column(Storage = "_isEnable", Name = "IsEnable", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsEnable
        {
            get
            {
                return this._isEnable;
            }
            set
            {
                if ((_isEnable != value))
                {
                    this.OnIsEnableChanging(value);
                    this.SendPropertyChanging();
                    this._isEnable = value;
                    this.SendPropertyChanged("IsEnable");
                    this.OnIsEnableChanged();
                }
            }
        }

        [Column(Storage = "_name", Name = "Name", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (((_name == value)
                            == false))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        [Column(Storage = "_seq", Name = "Seq", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int Seq
        {
            get
            {
                return this._seq;
            }
            set
            {
                if ((_seq != value))
                {
                    this.OnSeqChanging(value);
                    this.SendPropertyChanging();
                    this._seq = value;
                    this.SendPropertyChanged("Seq");
                    this.OnSeqChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.flownodedef")]
    public partial class FlownOdeDef : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private string _desc;

        private string _flowID;

        private sbyte _isCheck;

        private sbyte _isEnable;

        private sbyte _isQpproval;

        private sbyte _isSplit;

        private sbyte _isUnite;

        private string _name;

        private string _nodeID;

        private int _seq;

        private string _target;

        private sbyte _type;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnDescChanged();

        partial void OnDescChanging(string value);

        partial void OnFlowIDChanged();

        partial void OnFlowIDChanging(string value);

        partial void OnIsCheckChanged();

        partial void OnIsCheckChanging(sbyte value);

        partial void OnIsEnableChanged();

        partial void OnIsEnableChanging(sbyte value);

        partial void OnIsQpprovalChanged();

        partial void OnIsQpprovalChanging(sbyte value);

        partial void OnIsSplitChanged();

        partial void OnIsSplitChanging(sbyte value);

        partial void OnIsUniteChanged();

        partial void OnIsUniteChanging(sbyte value);

        partial void OnNameChanged();

        partial void OnNameChanging(string value);

        partial void OnNodeIDChanged();

        partial void OnNodeIDChanging(string value);

        partial void OnSeqChanged();

        partial void OnSeqChanging(int value);

        partial void OnTargetChanged();

        partial void OnTargetChanging(string value);

        partial void OnTypeChanged();

        partial void OnTypeChanging(sbyte value);
        #endregion


        public FlownOdeDef()
        {
            this.OnCreated();
        }

        [Column(Storage = "_desc", Name = "Desc", DbType = "varchar(500)", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Desc
        {
            get
            {
                return this._desc;
            }
            set
            {
                if (((_desc == value)
                            == false))
                {
                    this.OnDescChanging(value);
                    this.SendPropertyChanging();
                    this._desc = value;
                    this.SendPropertyChanged("Desc");
                    this.OnDescChanged();
                }
            }
        }

        [Column(Storage = "_flowID", Name = "FlowId", DbType = "varchar(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string FlowID
        {
            get
            {
                return this._flowID;
            }
            set
            {
                if (((_flowID == value)
                            == false))
                {
                    this.OnFlowIDChanging(value);
                    this.SendPropertyChanging();
                    this._flowID = value;
                    this.SendPropertyChanged("FlowID");
                    this.OnFlowIDChanged();
                }
            }
        }

        [Column(Storage = "_isCheck", Name = "IsCheck", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsCheck
        {
            get
            {
                return this._isCheck;
            }
            set
            {
                if ((_isCheck != value))
                {
                    this.OnIsCheckChanging(value);
                    this.SendPropertyChanging();
                    this._isCheck = value;
                    this.SendPropertyChanged("IsCheck");
                    this.OnIsCheckChanged();
                }
            }
        }

        [Column(Storage = "_isEnable", Name = "IsEnable", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsEnable
        {
            get
            {
                return this._isEnable;
            }
            set
            {
                if ((_isEnable != value))
                {
                    this.OnIsEnableChanging(value);
                    this.SendPropertyChanging();
                    this._isEnable = value;
                    this.SendPropertyChanged("IsEnable");
                    this.OnIsEnableChanged();
                }
            }
        }

        [Column(Storage = "_isQpproval", Name = "IsQpproval", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsQpproval
        {
            get
            {
                return this._isQpproval;
            }
            set
            {
                if ((_isQpproval != value))
                {
                    this.OnIsQpprovalChanging(value);
                    this.SendPropertyChanging();
                    this._isQpproval = value;
                    this.SendPropertyChanged("IsQpproval");
                    this.OnIsQpprovalChanged();
                }
            }
        }

        [Column(Storage = "_isSplit", Name = "IsSplit", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsSplit
        {
            get
            {
                return this._isSplit;
            }
            set
            {
                if ((_isSplit != value))
                {
                    this.OnIsSplitChanging(value);
                    this.SendPropertyChanging();
                    this._isSplit = value;
                    this.SendPropertyChanged("IsSplit");
                    this.OnIsSplitChanged();
                }
            }
        }

        [Column(Storage = "_isUnite", Name = "IsUnite", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsUnite
        {
            get
            {
                return this._isUnite;
            }
            set
            {
                if ((_isUnite != value))
                {
                    this.OnIsUniteChanging(value);
                    this.SendPropertyChanging();
                    this._isUnite = value;
                    this.SendPropertyChanged("IsUnite");
                    this.OnIsUniteChanged();
                }
            }
        }

        [Column(Storage = "_name", Name = "Name", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (((_name == value)
                            == false))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        [Column(Storage = "_nodeID", Name = "NodeId", DbType = "varchar(20)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string NodeID
        {
            get
            {
                return this._nodeID;
            }
            set
            {
                if (((_nodeID == value)
                            == false))
                {
                    this.OnNodeIDChanging(value);
                    this.SendPropertyChanging();
                    this._nodeID = value;
                    this.SendPropertyChanged("NodeID");
                    this.OnNodeIDChanged();
                }
            }
        }

        [Column(Storage = "_seq", Name = "Seq", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int Seq
        {
            get
            {
                return this._seq;
            }
            set
            {
                if ((_seq != value))
                {
                    this.OnSeqChanging(value);
                    this.SendPropertyChanging();
                    this._seq = value;
                    this.SendPropertyChanged("Seq");
                    this.OnSeqChanged();
                }
            }
        }

        [Column(Storage = "_target", Name = "Target", DbType = "varchar(500)", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Target
        {
            get
            {
                return this._target;
            }
            set
            {
                if (((_target == value)
                            == false))
                {
                    this.OnTargetChanging(value);
                    this.SendPropertyChanging();
                    this._target = value;
                    this.SendPropertyChanged("Target");
                    this.OnTargetChanged();
                }
            }
        }

        [Column(Storage = "_type", Name = "Type", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if ((_type != value))
                {
                    this.OnTypeChanging(value);
                    this.SendPropertyChanging();
                    this._type = value;
                    this.SendPropertyChanged("Type");
                    this.OnTypeChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.flownoderole")]
    public partial class FlownOderOle : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _id;

        private string _nodeID;

        private int _roleID;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnNodeIDChanged();

        partial void OnNodeIDChanging(string value);

        partial void OnRoleIDChanged();

        partial void OnRoleIDChanging(int value);
        #endregion


        public FlownOderOle()
        {
            this.OnCreated();
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_nodeID", Name = "NodeId", DbType = "varchar(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string NodeID
        {
            get
            {
                return this._nodeID;
            }
            set
            {
                if (((_nodeID == value)
                            == false))
                {
                    this.OnNodeIDChanging(value);
                    this.SendPropertyChanging();
                    this._nodeID = value;
                    this.SendPropertyChanged("NodeID");
                    this.OnNodeIDChanged();
                }
            }
        }

        [Column(Storage = "_roleID", Name = "RoleId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int RoleID
        {
            get
            {
                return this._roleID;
            }
            set
            {
                if ((_roleID != value))
                {
                    this.OnRoleIDChanging(value);
                    this.SendPropertyChanging();
                    this._roleID = value;
                    this.SendPropertyChanged("RoleID");
                    this.OnRoleIDChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.flownoderuninfo")]
    public partial class FlownOderUnInfo : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _ciD;

        private System.DateTime _createTime;

        private string _creatorFullName;

        private string _creatorID;

        private string _desc;

        private string _fromNodeID;

        private int _id;

        private string _operaName;

        private string _operatorFullName;

        private string _operatorID;

        private int _requirementID;

        private string _toNodeID;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnCiDChanged();

        partial void OnCiDChanging(int value);

        partial void OnCreateTimeChanged();

        partial void OnCreateTimeChanging(System.DateTime value);

        partial void OnCreatorFullNameChanged();

        partial void OnCreatorFullNameChanging(string value);

        partial void OnCreatorIDChanged();

        partial void OnCreatorIDChanging(string value);

        partial void OnDescChanged();

        partial void OnDescChanging(string value);

        partial void OnFromNodeIDChanged();

        partial void OnFromNodeIDChanging(string value);

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnOperaNameChanged();

        partial void OnOperaNameChanging(string value);

        partial void OnOperatorFullNameChanged();

        partial void OnOperatorFullNameChanging(string value);

        partial void OnOperatorIDChanged();

        partial void OnOperatorIDChanging(string value);

        partial void OnRequirementIDChanged();

        partial void OnRequirementIDChanging(int value);

        partial void OnToNodeIDChanged();

        partial void OnToNodeIDChanging(string value);
        #endregion


        public FlownOderUnInfo()
        {
            this.OnCreated();
        }

        [Column(Storage = "_ciD", Name = "CId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int CiD
        {
            get
            {
                return this._ciD;
            }
            set
            {
                if ((_ciD != value))
                {
                    this.OnCiDChanging(value);
                    this.SendPropertyChanging();
                    this._ciD = value;
                    this.SendPropertyChanged("CiD");
                    this.OnCiDChanged();
                }
            }
        }

        [Column(Storage = "_createTime", Name = "CreateTime", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public System.DateTime CreateTime
        {
            get
            {
                return this._createTime;
            }
            set
            {
                if ((_createTime != value))
                {
                    this.OnCreateTimeChanging(value);
                    this.SendPropertyChanging();
                    this._createTime = value;
                    this.SendPropertyChanged("CreateTime");
                    this.OnCreateTimeChanged();
                }
            }
        }

        [Column(Storage = "_creatorFullName", Name = "CreatorFullName", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string CreatorFullName
        {
            get
            {
                return this._creatorFullName;
            }
            set
            {
                if (((_creatorFullName == value)
                            == false))
                {
                    this.OnCreatorFullNameChanging(value);
                    this.SendPropertyChanging();
                    this._creatorFullName = value;
                    this.SendPropertyChanged("CreatorFullName");
                    this.OnCreatorFullNameChanged();
                }
            }
        }

        [Column(Storage = "_creatorID", Name = "CreatorId", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string CreatorID
        {
            get
            {
                return this._creatorID;
            }
            set
            {
                if (((_creatorID == value)
                            == false))
                {
                    this.OnCreatorIDChanging(value);
                    this.SendPropertyChanging();
                    this._creatorID = value;
                    this.SendPropertyChanged("CreatorID");
                    this.OnCreatorIDChanged();
                }
            }
        }

        [Column(Storage = "_desc", Name = "Desc", DbType = "text", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Desc
        {
            get
            {
                return this._desc;
            }
            set
            {
                if (((_desc == value)
                            == false))
                {
                    this.OnDescChanging(value);
                    this.SendPropertyChanging();
                    this._desc = value;
                    this.SendPropertyChanged("Desc");
                    this.OnDescChanged();
                }
            }
        }

        [Column(Storage = "_fromNodeID", Name = "FromNodeId", DbType = "varchar(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string FromNodeID
        {
            get
            {
                return this._fromNodeID;
            }
            set
            {
                if (((_fromNodeID == value)
                            == false))
                {
                    this.OnFromNodeIDChanging(value);
                    this.SendPropertyChanging();
                    this._fromNodeID = value;
                    this.SendPropertyChanged("FromNodeID");
                    this.OnFromNodeIDChanged();
                }
            }
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_operaName", Name = "OperaName", DbType = "varchar(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string OperaName
        {
            get
            {
                return this._operaName;
            }
            set
            {
                if (((_operaName == value)
                            == false))
                {
                    this.OnOperaNameChanging(value);
                    this.SendPropertyChanging();
                    this._operaName = value;
                    this.SendPropertyChanged("OperaName");
                    this.OnOperaNameChanged();
                }
            }
        }

        [Column(Storage = "_operatorFullName", Name = "OperatorFullName", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string OperatorFullName
        {
            get
            {
                return this._operatorFullName;
            }
            set
            {
                if (((_operatorFullName == value)
                            == false))
                {
                    this.OnOperatorFullNameChanging(value);
                    this.SendPropertyChanging();
                    this._operatorFullName = value;
                    this.SendPropertyChanged("OperatorFullName");
                    this.OnOperatorFullNameChanged();
                }
            }
        }

        [Column(Storage = "_operatorID", Name = "OperatorId", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string OperatorID
        {
            get
            {
                return this._operatorID;
            }
            set
            {
                if (((_operatorID == value)
                            == false))
                {
                    this.OnOperatorIDChanging(value);
                    this.SendPropertyChanging();
                    this._operatorID = value;
                    this.SendPropertyChanged("OperatorID");
                    this.OnOperatorIDChanged();
                }
            }
        }

        [Column(Storage = "_requirementID", Name = "RequirementId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int RequirementID
        {
            get
            {
                return this._requirementID;
            }
            set
            {
                if ((_requirementID != value))
                {
                    this.OnRequirementIDChanging(value);
                    this.SendPropertyChanging();
                    this._requirementID = value;
                    this.SendPropertyChanged("RequirementID");
                    this.OnRequirementIDChanged();
                }
            }
        }

        [Column(Storage = "_toNodeID", Name = "ToNodeId", DbType = "varchar(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string ToNodeID
        {
            get
            {
                return this._toNodeID;
            }
            set
            {
                if (((_toNodeID == value)
                            == false))
                {
                    this.OnToNodeIDChanging(value);
                    this.SendPropertyChanging();
                    this._toNodeID = value;
                    this.SendPropertyChanged("ToNodeID");
                    this.OnToNodeIDChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.flowrule")]
    public partial class FlowRule : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private string _desc;

        private string _fromNodeID;

        private int _id;

        private sbyte _isEnable;

        private string _operaName;

        private string _toNodeID;

        private int _toStatusID;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnDescChanged();

        partial void OnDescChanging(string value);

        partial void OnFromNodeIDChanged();

        partial void OnFromNodeIDChanging(string value);

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnIsEnableChanged();

        partial void OnIsEnableChanging(sbyte value);

        partial void OnOperaNameChanged();

        partial void OnOperaNameChanging(string value);

        partial void OnToNodeIDChanged();

        partial void OnToNodeIDChanging(string value);

        partial void OnToStatusIDChanged();

        partial void OnToStatusIDChanging(int value);
        #endregion


        public FlowRule()
        {
            this.OnCreated();
        }

        [Column(Storage = "_desc", Name = "Desc", DbType = "varchar(500)", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Desc
        {
            get
            {
                return this._desc;
            }
            set
            {
                if (((_desc == value)
                            == false))
                {
                    this.OnDescChanging(value);
                    this.SendPropertyChanging();
                    this._desc = value;
                    this.SendPropertyChanged("Desc");
                    this.OnDescChanged();
                }
            }
        }

        [Column(Storage = "_fromNodeID", Name = "FromNodeId", DbType = "varchar(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string FromNodeID
        {
            get
            {
                return this._fromNodeID;
            }
            set
            {
                if (((_fromNodeID == value)
                            == false))
                {
                    this.OnFromNodeIDChanging(value);
                    this.SendPropertyChanging();
                    this._fromNodeID = value;
                    this.SendPropertyChanged("FromNodeID");
                    this.OnFromNodeIDChanged();
                }
            }
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_isEnable", Name = "IsEnable", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsEnable
        {
            get
            {
                return this._isEnable;
            }
            set
            {
                if ((_isEnable != value))
                {
                    this.OnIsEnableChanging(value);
                    this.SendPropertyChanging();
                    this._isEnable = value;
                    this.SendPropertyChanged("IsEnable");
                    this.OnIsEnableChanged();
                }
            }
        }

        [Column(Storage = "_operaName", Name = "OperaName", DbType = "varchar(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string OperaName
        {
            get
            {
                return this._operaName;
            }
            set
            {
                if (((_operaName == value)
                            == false))
                {
                    this.OnOperaNameChanging(value);
                    this.SendPropertyChanging();
                    this._operaName = value;
                    this.SendPropertyChanged("OperaName");
                    this.OnOperaNameChanged();
                }
            }
        }

        [Column(Storage = "_toNodeID", Name = "ToNodeId", DbType = "varchar(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string ToNodeID
        {
            get
            {
                return this._toNodeID;
            }
            set
            {
                if (((_toNodeID == value)
                            == false))
                {
                    this.OnToNodeIDChanging(value);
                    this.SendPropertyChanging();
                    this._toNodeID = value;
                    this.SendPropertyChanged("ToNodeID");
                    this.OnToNodeIDChanged();
                }
            }
        }

        [Column(Storage = "_toStatusID", Name = "ToStatusId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ToStatusID
        {
            get
            {
                return this._toStatusID;
            }
            set
            {
                if ((_toStatusID != value))
                {
                    this.OnToStatusIDChanging(value);
                    this.SendPropertyChanging();
                    this._toStatusID = value;
                    this.SendPropertyChanged("ToStatusID");
                    this.OnToStatusIDChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.production")]
    public partial class Production : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _id;

        private int _isEnabled;

        private string _name;

        private string _pid;

        private string _productionValue;

        private int _studioID;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnIsEnabledChanged();

        partial void OnIsEnabledChanging(int value);

        partial void OnNameChanged();

        partial void OnNameChanging(string value);

        partial void OnPidChanged();

        partial void OnPidChanging(string value);

        partial void OnProductionValueChanged();

        partial void OnProductionValueChanging(string value);

        partial void OnStudioIDChanged();

        partial void OnStudioIDChanging(int value);
        #endregion


        public Production()
        {
            this.OnCreated();
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_isEnabled", Name = "IsEnabled", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int IsEnabled
        {
            get
            {
                return this._isEnabled;
            }
            set
            {
                if ((_isEnabled != value))
                {
                    this.OnIsEnabledChanging(value);
                    this.SendPropertyChanging();
                    this._isEnabled = value;
                    this.SendPropertyChanged("IsEnabled");
                    this.OnIsEnabledChanged();
                }
            }
        }

        [Column(Storage = "_name", Name = "Name", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (((_name == value)
                            == false))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        [Column(Storage = "_pid", Name = "Pid", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Pid
        {
            get
            {
                return this._pid;
            }
            set
            {
                if (((_pid == value)
                            == false))
                {
                    this.OnPidChanging(value);
                    this.SendPropertyChanging();
                    this._pid = value;
                    this.SendPropertyChanged("Pid");
                    this.OnPidChanged();
                }
            }
        }

        [Column(Storage = "_productionValue", Name = "ProductionValue", DbType = "varchar(200)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string ProductionValue
        {
            get
            {
                return this._productionValue;
            }
            set
            {
                if (((_productionValue == value)
                            == false))
                {
                    this.OnProductionValueChanging(value);
                    this.SendPropertyChanging();
                    this._productionValue = value;
                    this.SendPropertyChanged("ProductionValue");
                    this.OnProductionValueChanged();
                }
            }
        }

        [Column(Storage = "_studioID", Name = "StudioId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int StudioID
        {
            get
            {
                return this._studioID;
            }
            set
            {
                if ((_studioID != value))
                {
                    this.OnStudioIDChanging(value);
                    this.SendPropertyChanging();
                    this._studioID = value;
                    this.SendPropertyChanged("StudioID");
                    this.OnStudioIDChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.productionstage")]
    public partial class ProductionStage : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private string _desc;

        private int _id;

        private sbyte _isEnabled;

        private string _name;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnDescChanged();

        partial void OnDescChanging(string value);

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnIsEnabledChanged();

        partial void OnIsEnabledChanging(sbyte value);

        partial void OnNameChanged();

        partial void OnNameChanging(string value);
        #endregion


        public ProductionStage()
        {
            this.OnCreated();
        }

        [Column(Storage = "_desc", Name = "Desc", DbType = "varchar(500)", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Desc
        {
            get
            {
                return this._desc;
            }
            set
            {
                if (((_desc == value)
                            == false))
                {
                    this.OnDescChanging(value);
                    this.SendPropertyChanging();
                    this._desc = value;
                    this.SendPropertyChanged("Desc");
                    this.OnDescChanged();
                }
            }
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_isEnabled", Name = "IsEnabled", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsEnabled
        {
            get
            {
                return this._isEnabled;
            }
            set
            {
                if ((_isEnabled != value))
                {
                    this.OnIsEnabledChanging(value);
                    this.SendPropertyChanging();
                    this._isEnabled = value;
                    this.SendPropertyChanged("IsEnabled");
                    this.OnIsEnabledChanged();
                }
            }
        }

        [Column(Storage = "_name", Name = "Name", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (((_name == value)
                            == false))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.productionuserrole")]
    public partial class ProductionUserRole : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _id;

        private int _productionID;

        private int _roleID;

        private string _userFullName;

        private string _userID;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnProductionIDChanged();

        partial void OnProductionIDChanging(int value);

        partial void OnRoleIDChanged();

        partial void OnRoleIDChanging(int value);

        partial void OnUserFullNameChanged();

        partial void OnUserFullNameChanging(string value);

        partial void OnUserIDChanged();

        partial void OnUserIDChanging(string value);
        #endregion


        public ProductionUserRole()
        {
            this.OnCreated();
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_productionID", Name = "ProductionId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ProductionID
        {
            get
            {
                return this._productionID;
            }
            set
            {
                if ((_productionID != value))
                {
                    this.OnProductionIDChanging(value);
                    this.SendPropertyChanging();
                    this._productionID = value;
                    this.SendPropertyChanged("ProductionID");
                    this.OnProductionIDChanged();
                }
            }
        }

        [Column(Storage = "_roleID", Name = "RoleId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int RoleID
        {
            get
            {
                return this._roleID;
            }
            set
            {
                if ((_roleID != value))
                {
                    this.OnRoleIDChanging(value);
                    this.SendPropertyChanging();
                    this._roleID = value;
                    this.SendPropertyChanged("RoleID");
                    this.OnRoleIDChanged();
                }
            }
        }

        [Column(Storage = "_userFullName", Name = "UserFullName", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string UserFullName
        {
            get
            {
                return this._userFullName;
            }
            set
            {
                if (((_userFullName == value)
                            == false))
                {
                    this.OnUserFullNameChanging(value);
                    this.SendPropertyChanging();
                    this._userFullName = value;
                    this.SendPropertyChanged("UserFullName");
                    this.OnUserFullNameChanged();
                }
            }
        }

        [Column(Storage = "_userID", Name = "UserId", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string UserID
        {
            get
            {
                return this._userID;
            }
            set
            {
                if (((_userID == value)
                            == false))
                {
                    this.OnUserIDChanging(value);
                    this.SendPropertyChanging();
                    this._userID = value;
                    this.SendPropertyChanged("UserID");
                    this.OnUserIDChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.requirement")]
    public partial class Requirement : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private string _backgroud;

        private System.DateTime _createTime;

        private string _creatorFulleName;

        private string _creatorID;

        private string _curNodeID;

        private string _detail;

        private int _id;

        private sbyte _isEnd;

        private sbyte _isSplited;

        private string _operatorFullName;

        private string _operatorID;

        private int _productionID;

        private int _productionStageID;

        private System.DateTime _requirementTime;

        private string _rid;

        private int _statusID;

        private string _title;

        private System.DateTime _updateTime;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnBackgroudChanged();

        partial void OnBackgroudChanging(string value);

        partial void OnCreateTimeChanged();

        partial void OnCreateTimeChanging(System.DateTime value);

        partial void OnCreatorFulleNameChanged();

        partial void OnCreatorFulleNameChanging(string value);

        partial void OnCreatorIDChanged();

        partial void OnCreatorIDChanging(string value);

        partial void OnCurNodeIDChanged();

        partial void OnCurNodeIDChanging(string value);

        partial void OnDetailChanged();

        partial void OnDetailChanging(string value);

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnIsEndChanged();

        partial void OnIsEndChanging(sbyte value);

        partial void OnIsSplitedChanged();

        partial void OnIsSplitedChanging(sbyte value);

        partial void OnOperatorFullNameChanged();

        partial void OnOperatorFullNameChanging(string value);

        partial void OnOperatorIDChanged();

        partial void OnOperatorIDChanging(string value);

        partial void OnProductionIDChanged();

        partial void OnProductionIDChanging(int value);

        partial void OnProductionStageIDChanged();

        partial void OnProductionStageIDChanging(int value);

        partial void OnRequirementTimeChanged();

        partial void OnRequirementTimeChanging(System.DateTime value);

        partial void OnRidChanged();

        partial void OnRidChanging(string value);

        partial void OnStatusIDChanged();

        partial void OnStatusIDChanging(int value);

        partial void OnTitleChanged();

        partial void OnTitleChanging(string value);

        partial void OnUpdateTimeChanged();

        partial void OnUpdateTimeChanging(System.DateTime value);
        #endregion


        public Requirement()
        {
            this.OnCreated();
        }

        [Column(Storage = "_backgroud", Name = "Backgroud", DbType = "text", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Backgroud
        {
            get
            {
                return this._backgroud;
            }
            set
            {
                if (((_backgroud == value)
                            == false))
                {
                    this.OnBackgroudChanging(value);
                    this.SendPropertyChanging();
                    this._backgroud = value;
                    this.SendPropertyChanged("Backgroud");
                    this.OnBackgroudChanged();
                }
            }
        }

        [Column(Storage = "_createTime", Name = "CreateTime", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public System.DateTime CreateTime
        {
            get
            {
                return this._createTime;
            }
            set
            {
                if ((_createTime != value))
                {
                    this.OnCreateTimeChanging(value);
                    this.SendPropertyChanging();
                    this._createTime = value;
                    this.SendPropertyChanged("CreateTime");
                    this.OnCreateTimeChanged();
                }
            }
        }

        [Column(Storage = "_creatorFulleName", Name = "CreatorFulleName", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string CreatorFulleName
        {
            get
            {
                return this._creatorFulleName;
            }
            set
            {
                if (((_creatorFulleName == value)
                            == false))
                {
                    this.OnCreatorFulleNameChanging(value);
                    this.SendPropertyChanging();
                    this._creatorFulleName = value;
                    this.SendPropertyChanged("CreatorFulleName");
                    this.OnCreatorFulleNameChanged();
                }
            }
        }

        [Column(Storage = "_creatorID", Name = "CreatorId", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string CreatorID
        {
            get
            {
                return this._creatorID;
            }
            set
            {
                if (((_creatorID == value)
                            == false))
                {
                    this.OnCreatorIDChanging(value);
                    this.SendPropertyChanging();
                    this._creatorID = value;
                    this.SendPropertyChanged("CreatorID");
                    this.OnCreatorIDChanged();
                }
            }
        }

        [Column(Storage = "_curNodeID", Name = "CurNodeId", DbType = "varchar(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string CurNodeID
        {
            get
            {
                return this._curNodeID;
            }
            set
            {
                if (((_curNodeID == value)
                            == false))
                {
                    this.OnCurNodeIDChanging(value);
                    this.SendPropertyChanging();
                    this._curNodeID = value;
                    this.SendPropertyChanged("CurNodeID");
                    this.OnCurNodeIDChanged();
                }
            }
        }

        [Column(Storage = "_detail", Name = "Detail", DbType = "text", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Detail
        {
            get
            {
                return this._detail;
            }
            set
            {
                if (((_detail == value)
                            == false))
                {
                    this.OnDetailChanging(value);
                    this.SendPropertyChanging();
                    this._detail = value;
                    this.SendPropertyChanged("Detail");
                    this.OnDetailChanged();
                }
            }
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_isEnd", Name = "IsEnd", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsEnd
        {
            get
            {
                return this._isEnd;
            }
            set
            {
                if ((_isEnd != value))
                {
                    this.OnIsEndChanging(value);
                    this.SendPropertyChanging();
                    this._isEnd = value;
                    this.SendPropertyChanged("IsEnd");
                    this.OnIsEndChanged();
                }
            }
        }

        [Column(Storage = "_isSplited", Name = "IsSplited", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsSplited
        {
            get
            {
                return this._isSplited;
            }
            set
            {
                if ((_isSplited != value))
                {
                    this.OnIsSplitedChanging(value);
                    this.SendPropertyChanging();
                    this._isSplited = value;
                    this.SendPropertyChanged("IsSplited");
                    this.OnIsSplitedChanged();
                }
            }
        }

        [Column(Storage = "_operatorFullName", Name = "OperatorFullName", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string OperatorFullName
        {
            get
            {
                return this._operatorFullName;
            }
            set
            {
                if (((_operatorFullName == value)
                            == false))
                {
                    this.OnOperatorFullNameChanging(value);
                    this.SendPropertyChanging();
                    this._operatorFullName = value;
                    this.SendPropertyChanged("OperatorFullName");
                    this.OnOperatorFullNameChanged();
                }
            }
        }

        [Column(Storage = "_operatorID", Name = "OperatorId", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string OperatorID
        {
            get
            {
                return this._operatorID;
            }
            set
            {
                if (((_operatorID == value)
                            == false))
                {
                    this.OnOperatorIDChanging(value);
                    this.SendPropertyChanging();
                    this._operatorID = value;
                    this.SendPropertyChanged("OperatorID");
                    this.OnOperatorIDChanged();
                }
            }
        }

        [Column(Storage = "_productionID", Name = "ProductionId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ProductionID
        {
            get
            {
                return this._productionID;
            }
            set
            {
                if ((_productionID != value))
                {
                    this.OnProductionIDChanging(value);
                    this.SendPropertyChanging();
                    this._productionID = value;
                    this.SendPropertyChanged("ProductionID");
                    this.OnProductionIDChanged();
                }
            }
        }

        [Column(Storage = "_productionStageID", Name = "ProductionStageId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ProductionStageID
        {
            get
            {
                return this._productionStageID;
            }
            set
            {
                if ((_productionStageID != value))
                {
                    this.OnProductionStageIDChanging(value);
                    this.SendPropertyChanging();
                    this._productionStageID = value;
                    this.SendPropertyChanged("ProductionStageID");
                    this.OnProductionStageIDChanged();
                }
            }
        }

        [Column(Storage = "_requirementTime", Name = "RequirementTime", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public System.DateTime RequirementTime
        {
            get
            {
                return this._requirementTime;
            }
            set
            {
                if ((_requirementTime != value))
                {
                    this.OnRequirementTimeChanging(value);
                    this.SendPropertyChanging();
                    this._requirementTime = value;
                    this.SendPropertyChanged("RequirementTime");
                    this.OnRequirementTimeChanged();
                }
            }
        }

        [Column(Storage = "_rid", Name = "RID", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Rid
        {
            get
            {
                return this._rid;
            }
            set
            {
                if (((_rid == value)
                            == false))
                {
                    this.OnRidChanging(value);
                    this.SendPropertyChanging();
                    this._rid = value;
                    this.SendPropertyChanged("Rid");
                    this.OnRidChanged();
                }
            }
        }

        [Column(Storage = "_statusID", Name = "StatusId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int StatusID
        {
            get
            {
                return this._statusID;
            }
            set
            {
                if ((_statusID != value))
                {
                    this.OnStatusIDChanging(value);
                    this.SendPropertyChanging();
                    this._statusID = value;
                    this.SendPropertyChanged("StatusID");
                    this.OnStatusIDChanged();
                }
            }
        }

        [Column(Storage = "_title", Name = "Title", DbType = "varchar(200)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                if (((_title == value)
                            == false))
                {
                    this.OnTitleChanging(value);
                    this.SendPropertyChanging();
                    this._title = value;
                    this.SendPropertyChanged("Title");
                    this.OnTitleChanged();
                }
            }
        }

        [Column(Storage = "_updateTime", Name = "UpdateTime", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public System.DateTime UpdateTime
        {
            get
            {
                return this._updateTime;
            }
            set
            {
                if ((_updateTime != value))
                {
                    this.OnUpdateTimeChanging(value);
                    this.SendPropertyChanging();
                    this._updateTime = value;
                    this.SendPropertyChanged("UpdateTime");
                    this.OnUpdateTimeChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// 新建一个RID
        /// </summary>
        /// <returns></returns>
        public static string NewRID()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssffffff");
        }
    }

    [Table(Name = "oapr.requirementchild")]
    public partial class RequirementChild : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private string _createFullName;

        private System.DateTime _createTime;

        private string _creatorID;

        private string _flowNodeID;

        private int _id;

        private string _operatorFullName;

        private string _operatorID;

        private int _requirementID;

        private int _statusID;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnCreateFullNameChanged();

        partial void OnCreateFullNameChanging(string value);

        partial void OnCreateTimeChanged();

        partial void OnCreateTimeChanging(System.DateTime value);

        partial void OnCreatorIDChanged();

        partial void OnCreatorIDChanging(string value);

        partial void OnFlowNodeIDChanged();

        partial void OnFlowNodeIDChanging(string value);

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnOperatorFullNameChanged();

        partial void OnOperatorFullNameChanging(string value);

        partial void OnOperatorIDChanged();

        partial void OnOperatorIDChanging(string value);

        partial void OnRequirementIDChanged();

        partial void OnRequirementIDChanging(int value);

        partial void OnStatusIDChanged();

        partial void OnStatusIDChanging(int value);
        #endregion


        public RequirementChild()
        {
            this.OnCreated();
        }

        [Column(Storage = "_createFullName", Name = "CreateFullName", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string CreateFullName
        {
            get
            {
                return this._createFullName;
            }
            set
            {
                if (((_createFullName == value)
                            == false))
                {
                    this.OnCreateFullNameChanging(value);
                    this.SendPropertyChanging();
                    this._createFullName = value;
                    this.SendPropertyChanged("CreateFullName");
                    this.OnCreateFullNameChanged();
                }
            }
        }

        [Column(Storage = "_createTime", Name = "CreateTime", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public System.DateTime CreateTime
        {
            get
            {
                return this._createTime;
            }
            set
            {
                if ((_createTime != value))
                {
                    this.OnCreateTimeChanging(value);
                    this.SendPropertyChanging();
                    this._createTime = value;
                    this.SendPropertyChanged("CreateTime");
                    this.OnCreateTimeChanged();
                }
            }
        }

        [Column(Storage = "_creatorID", Name = "CreatorId", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string CreatorID
        {
            get
            {
                return this._creatorID;
            }
            set
            {
                if (((_creatorID == value)
                            == false))
                {
                    this.OnCreatorIDChanging(value);
                    this.SendPropertyChanging();
                    this._creatorID = value;
                    this.SendPropertyChanged("CreatorID");
                    this.OnCreatorIDChanged();
                }
            }
        }

        [Column(Storage = "_flowNodeID", Name = "FlowNodeId", DbType = "varchar(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string FlowNodeID
        {
            get
            {
                return this._flowNodeID;
            }
            set
            {
                if (((_flowNodeID == value)
                            == false))
                {
                    this.OnFlowNodeIDChanging(value);
                    this.SendPropertyChanging();
                    this._flowNodeID = value;
                    this.SendPropertyChanged("FlowNodeID");
                    this.OnFlowNodeIDChanged();
                }
            }
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_operatorFullName", Name = "OperatorFullName", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string OperatorFullName
        {
            get
            {
                return this._operatorFullName;
            }
            set
            {
                if (((_operatorFullName == value)
                            == false))
                {
                    this.OnOperatorFullNameChanging(value);
                    this.SendPropertyChanging();
                    this._operatorFullName = value;
                    this.SendPropertyChanged("OperatorFullName");
                    this.OnOperatorFullNameChanged();
                }
            }
        }

        [Column(Storage = "_operatorID", Name = "OperatorId", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string OperatorID
        {
            get
            {
                return this._operatorID;
            }
            set
            {
                if (((_operatorID == value)
                            == false))
                {
                    this.OnOperatorIDChanging(value);
                    this.SendPropertyChanging();
                    this._operatorID = value;
                    this.SendPropertyChanged("OperatorID");
                    this.OnOperatorIDChanged();
                }
            }
        }

        [Column(Storage = "_requirementID", Name = "RequirementId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int RequirementID
        {
            get
            {
                return this._requirementID;
            }
            set
            {
                if ((_requirementID != value))
                {
                    this.OnRequirementIDChanging(value);
                    this.SendPropertyChanging();
                    this._requirementID = value;
                    this.SendPropertyChanged("RequirementID");
                    this.OnRequirementIDChanged();
                }
            }
        }

        [Column(Storage = "_statusID", Name = "StatusId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int StatusID
        {
            get
            {
                return this._statusID;
            }
            set
            {
                if ((_statusID != value))
                {
                    this.OnStatusIDChanging(value);
                    this.SendPropertyChanging();
                    this._statusID = value;
                    this.SendPropertyChanged("StatusID");
                    this.OnStatusIDChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.requirementdetail")]
    public partial class RequirementDetail : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private string _acceptaceDesc;

        private int _ciD;

        private int _dataActualMp;

        private string _dataCreator;

        private string _dataCreatorFullName;

        private string _dataDesc;

        private int _dataLockedMp;

        private int _dataProgress;

        private string _desc;

        private int _id;

        private sbyte _isAccept;

        private sbyte _isDevelopAccept;

        private int _isRequestWebCreator;

        private sbyte _logState;

        private sbyte _priority;

        private int _requirementID;

        private string _title;

        private sbyte _type;

        private string _webCreator;

        private string _webCreatorFullName;

        private string _webDesc;

        private int _webLockedMp;

        private int _webProgress;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnAcceptaceDescChanged();

        partial void OnAcceptaceDescChanging(string value);

        partial void OnCiDChanged();

        partial void OnCiDChanging(int value);

        partial void OnDataActualMpChanged();

        partial void OnDataActualMpChanging(int value);

        partial void OnDataCreatorChanged();

        partial void OnDataCreatorChanging(string value);

        partial void OnDataCreatorFullNameChanged();

        partial void OnDataCreatorFullNameChanging(string value);

        partial void OnDataDescChanged();

        partial void OnDataDescChanging(string value);

        partial void OnDataLockedMpChanged();

        partial void OnDataLockedMpChanging(int value);

        partial void OnDataProgressChanged();

        partial void OnDataProgressChanging(int value);

        partial void OnDescChanged();

        partial void OnDescChanging(string value);

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnIsAcceptChanged();

        partial void OnIsAcceptChanging(sbyte value);

        partial void OnIsDevelopAcceptChanged();

        partial void OnIsDevelopAcceptChanging(sbyte value);

        partial void OnIsRequestWebCreatorChanged();

        partial void OnIsRequestWebCreatorChanging(int value);

        partial void OnLogStateChanged();

        partial void OnLogStateChanging(sbyte value);

        partial void OnPriorityChanged();

        partial void OnPriorityChanging(sbyte value);

        partial void OnRequirementIDChanged();

        partial void OnRequirementIDChanging(int value);

        partial void OnTitleChanged();

        partial void OnTitleChanging(string value);

        partial void OnTypeChanged();

        partial void OnTypeChanging(sbyte value);

        partial void OnWebCreatorChanged();

        partial void OnWebCreatorChanging(string value);

        partial void OnWebCreatorFullNameChanged();

        partial void OnWebCreatorFullNameChanging(string value);

        partial void OnWebDescChanged();

        partial void OnWebDescChanging(string value);

        partial void OnWebLockedMpChanged();

        partial void OnWebLockedMpChanging(int value);

        partial void OnWebProgressChanged();

        partial void OnWebProgressChanging(int value);
        #endregion


        public RequirementDetail()
        {
            this.OnCreated();
        }

        [Column(Storage = "_acceptaceDesc", Name = "AcceptaceDesc", DbType = "varchar(200)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string AcceptaceDesc
        {
            get
            {
                return this._acceptaceDesc;
            }
            set
            {
                if (((_acceptaceDesc == value)
                            == false))
                {
                    this.OnAcceptaceDescChanging(value);
                    this.SendPropertyChanging();
                    this._acceptaceDesc = value;
                    this.SendPropertyChanged("AcceptaceDesc");
                    this.OnAcceptaceDescChanged();
                }
            }
        }

        [Column(Storage = "_ciD", Name = "CId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int CiD
        {
            get
            {
                return this._ciD;
            }
            set
            {
                if ((_ciD != value))
                {
                    this.OnCiDChanging(value);
                    this.SendPropertyChanging();
                    this._ciD = value;
                    this.SendPropertyChanged("CiD");
                    this.OnCiDChanged();
                }
            }
        }

        [Column(Storage = "_dataActualMp", Name = "DataActualMP", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int DataActualMp
        {
            get
            {
                return this._dataActualMp;
            }
            set
            {
                if ((_dataActualMp != value))
                {
                    this.OnDataActualMpChanging(value);
                    this.SendPropertyChanging();
                    this._dataActualMp = value;
                    this.SendPropertyChanged("DataActualMp");
                    this.OnDataActualMpChanged();
                }
            }
        }

        [Column(Storage = "_dataCreator", Name = "DataCreator", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string DataCreator
        {
            get
            {
                return this._dataCreator;
            }
            set
            {
                if (((_dataCreator == value)
                            == false))
                {
                    this.OnDataCreatorChanging(value);
                    this.SendPropertyChanging();
                    this._dataCreator = value;
                    this.SendPropertyChanged("DataCreator");
                    this.OnDataCreatorChanged();
                }
            }
        }

        [Column(Storage = "_dataCreatorFullName", Name = "DataCreatorFullName", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string DataCreatorFullName
        {
            get
            {
                return this._dataCreatorFullName;
            }
            set
            {
                if (((_dataCreatorFullName == value)
                            == false))
                {
                    this.OnDataCreatorFullNameChanging(value);
                    this.SendPropertyChanging();
                    this._dataCreatorFullName = value;
                    this.SendPropertyChanged("DataCreatorFullName");
                    this.OnDataCreatorFullNameChanged();
                }
            }
        }

        [Column(Storage = "_dataDesc", Name = "DataDesc", DbType = "varchar(200)", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string DataDesc
        {
            get
            {
                return this._dataDesc;
            }
            set
            {
                if (((_dataDesc == value)
                            == false))
                {
                    this.OnDataDescChanging(value);
                    this.SendPropertyChanging();
                    this._dataDesc = value;
                    this.SendPropertyChanged("DataDesc");
                    this.OnDataDescChanged();
                }
            }
        }

        [Column(Storage = "_dataLockedMp", Name = "DataLockedMP", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int DataLockedMp
        {
            get
            {
                return this._dataLockedMp;
            }
            set
            {
                if ((_dataLockedMp != value))
                {
                    this.OnDataLockedMpChanging(value);
                    this.SendPropertyChanging();
                    this._dataLockedMp = value;
                    this.SendPropertyChanged("DataLockedMp");
                    this.OnDataLockedMpChanged();
                }
            }
        }

        [Column(Storage = "_dataProgress", Name = "DataProgress", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int DataProgress
        {
            get
            {
                return this._dataProgress;
            }
            set
            {
                if ((_dataProgress != value))
                {
                    this.OnDataProgressChanging(value);
                    this.SendPropertyChanging();
                    this._dataProgress = value;
                    this.SendPropertyChanged("DataProgress");
                    this.OnDataProgressChanged();
                }
            }
        }

        [Column(Storage = "_desc", Name = "Desc", DbType = "varchar(500)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Desc
        {
            get
            {
                return this._desc;
            }
            set
            {
                if (((_desc == value)
                            == false))
                {
                    this.OnDescChanging(value);
                    this.SendPropertyChanging();
                    this._desc = value;
                    this.SendPropertyChanged("Desc");
                    this.OnDescChanged();
                }
            }
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_isAccept", Name = "IsAccept", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsAccept
        {
            get
            {
                return this._isAccept;
            }
            set
            {
                if ((_isAccept != value))
                {
                    this.OnIsAcceptChanging(value);
                    this.SendPropertyChanging();
                    this._isAccept = value;
                    this.SendPropertyChanged("IsAccept");
                    this.OnIsAcceptChanged();
                }
            }
        }

        [Column(Storage = "_isDevelopAccept", Name = "IsDevelopAccept", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsDevelopAccept
        {
            get
            {
                return this._isDevelopAccept;
            }
            set
            {
                if ((_isDevelopAccept != value))
                {
                    this.OnIsDevelopAcceptChanging(value);
                    this.SendPropertyChanging();
                    this._isDevelopAccept = value;
                    this.SendPropertyChanged("IsDevelopAccept");
                    this.OnIsDevelopAcceptChanged();
                }
            }
        }

        [Column(Storage = "_isRequestWebCreator", Name = "IsRequestWebCreator", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int IsRequestWebCreator
        {
            get
            {
                return this._isRequestWebCreator;
            }
            set
            {
                if ((_isRequestWebCreator != value))
                {
                    this.OnIsRequestWebCreatorChanging(value);
                    this.SendPropertyChanging();
                    this._isRequestWebCreator = value;
                    this.SendPropertyChanged("IsRequestWebCreator");
                    this.OnIsRequestWebCreatorChanged();
                }
            }
        }

        [Column(Storage = "_logState", Name = "LogState", DbType = "tinyint", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte LogState
        {
            get
            {
                return this._logState;
            }
            set
            {
                if ((_logState != value))
                {
                    this.OnLogStateChanging(value);
                    this.SendPropertyChanging();
                    this._logState = value;
                    this.SendPropertyChanged("LogState");
                    this.OnLogStateChanged();
                }
            }
        }

        [Column(Storage = "_priority", Name = "Priority", DbType = "tinyint", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte Priority
        {
            get
            {
                return this._priority;
            }
            set
            {
                if ((_priority != value))
                {
                    this.OnPriorityChanging(value);
                    this.SendPropertyChanging();
                    this._priority = value;
                    this.SendPropertyChanged("Priority");
                    this.OnPriorityChanged();
                }
            }
        }

        [Column(Storage = "_requirementID", Name = "RequirementId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int RequirementID
        {
            get
            {
                return this._requirementID;
            }
            set
            {
                if ((_requirementID != value))
                {
                    this.OnRequirementIDChanging(value);
                    this.SendPropertyChanging();
                    this._requirementID = value;
                    this.SendPropertyChanged("RequirementID");
                    this.OnRequirementIDChanged();
                }
            }
        }

        [Column(Storage = "_title", Name = "Title", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                if (((_title == value)
                            == false))
                {
                    this.OnTitleChanging(value);
                    this.SendPropertyChanging();
                    this._title = value;
                    this.SendPropertyChanged("Title");
                    this.OnTitleChanged();
                }
            }
        }

        [Column(Storage = "_type", Name = "Type", DbType = "tinyint", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if ((_type != value))
                {
                    this.OnTypeChanging(value);
                    this.SendPropertyChanging();
                    this._type = value;
                    this.SendPropertyChanged("Type");
                    this.OnTypeChanged();
                }
            }
        }

        [Column(Storage = "_webCreator", Name = "WebCreator", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string WebCreator
        {
            get
            {
                return this._webCreator;
            }
            set
            {
                if (((_webCreator == value)
                            == false))
                {
                    this.OnWebCreatorChanging(value);
                    this.SendPropertyChanging();
                    this._webCreator = value;
                    this.SendPropertyChanged("WebCreator");
                    this.OnWebCreatorChanged();
                }
            }
        }

        [Column(Storage = "_webCreatorFullName", Name = "WebCreatorFullName", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string WebCreatorFullName
        {
            get
            {
                return this._webCreatorFullName;
            }
            set
            {
                if (((_webCreatorFullName == value)
                            == false))
                {
                    this.OnWebCreatorFullNameChanging(value);
                    this.SendPropertyChanging();
                    this._webCreatorFullName = value;
                    this.SendPropertyChanged("WebCreatorFullName");
                    this.OnWebCreatorFullNameChanged();
                }
            }
        }

        [Column(Storage = "_webDesc", Name = "WebDesc", DbType = "varchar(200)", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string WebDesc
        {
            get
            {
                return this._webDesc;
            }
            set
            {
                if (((_webDesc == value)
                            == false))
                {
                    this.OnWebDescChanging(value);
                    this.SendPropertyChanging();
                    this._webDesc = value;
                    this.SendPropertyChanged("WebDesc");
                    this.OnWebDescChanged();
                }
            }
        }

        [Column(Storage = "_webLockedMp", Name = "WebLockedMP", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int WebLockedMp
        {
            get
            {
                return this._webLockedMp;
            }
            set
            {
                if ((_webLockedMp != value))
                {
                    this.OnWebLockedMpChanging(value);
                    this.SendPropertyChanging();
                    this._webLockedMp = value;
                    this.SendPropertyChanged("WebLockedMp");
                    this.OnWebLockedMpChanged();
                }
            }
        }

        [Column(Storage = "_webProgress", Name = "WebProgress", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int WebProgress
        {
            get
            {
                return this._webProgress;
            }
            set
            {
                if ((_webProgress != value))
                {
                    this.OnWebProgressChanging(value);
                    this.SendPropertyChanging();
                    this._webProgress = value;
                    this.SendPropertyChanged("WebProgress");
                    this.OnWebProgressChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.requirementstaus")]
    public partial class RequirementsTauS : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private string _desc;

        private int _id;

        private sbyte _isEnable;

        private string _name;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnDescChanged();

        partial void OnDescChanging(string value);

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnIsEnableChanged();

        partial void OnIsEnableChanging(sbyte value);

        partial void OnNameChanged();

        partial void OnNameChanging(string value);
        #endregion


        public RequirementsTauS()
        {
            this.OnCreated();
        }

        [Column(Storage = "_desc", Name = "Desc", DbType = "varchar(500)", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Desc
        {
            get
            {
                return this._desc;
            }
            set
            {
                if (((_desc == value)
                            == false))
                {
                    this.OnDescChanging(value);
                    this.SendPropertyChanging();
                    this._desc = value;
                    this.SendPropertyChanged("Desc");
                    this.OnDescChanged();
                }
            }
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_isEnable", Name = "IsEnable", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsEnable
        {
            get
            {
                return this._isEnable;
            }
            set
            {
                if ((_isEnable != value))
                {
                    this.OnIsEnableChanging(value);
                    this.SendPropertyChanging();
                    this._isEnable = value;
                    this.SendPropertyChanged("IsEnable");
                    this.OnIsEnableChanged();
                }
            }
        }

        [Column(Storage = "_name", Name = "Name", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (((_name == value)
                            == false))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.role")]
    public partial class Role : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private string _desc;

        private int _id;

        private int _isEnable;

        private int _isMp;

        private string _name;

        private string _roleID;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnDescChanged();

        partial void OnDescChanging(string value);

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnIsEnableChanged();

        partial void OnIsEnableChanging(int value);

        partial void OnIsMpChanged();

        partial void OnIsMpChanging(int value);

        partial void OnNameChanged();

        partial void OnNameChanging(string value);

        partial void OnRoleIDChanged();

        partial void OnRoleIDChanging(string value);
        #endregion


        public Role()
        {
            this.OnCreated();
        }

        [Column(Storage = "_desc", Name = "Desc", DbType = "varchar(500)", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Desc
        {
            get
            {
                return this._desc;
            }
            set
            {
                if (((_desc == value)
                            == false))
                {
                    this.OnDescChanging(value);
                    this.SendPropertyChanging();
                    this._desc = value;
                    this.SendPropertyChanged("Desc");
                    this.OnDescChanged();
                }
            }
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_isEnable", Name = "IsEnable", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int IsEnable
        {
            get
            {
                return this._isEnable;
            }
            set
            {
                if ((_isEnable != value))
                {
                    this.OnIsEnableChanging(value);
                    this.SendPropertyChanging();
                    this._isEnable = value;
                    this.SendPropertyChanged("IsEnable");
                    this.OnIsEnableChanged();
                }
            }
        }

        [Column(Storage = "_isMp", Name = "IsMP", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int IsMp
        {
            get
            {
                return this._isMp;
            }
            set
            {
                if ((_isMp != value))
                {
                    this.OnIsMpChanging(value);
                    this.SendPropertyChanging();
                    this._isMp = value;
                    this.SendPropertyChanged("IsMp");
                    this.OnIsMpChanged();
                }
            }
        }

        [Column(Storage = "_name", Name = "Name", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (((_name == value)
                            == false))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        [Column(Storage = "_roleID", Name = "RoleId", DbType = "varchar(10)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string RoleID
        {
            get
            {
                return this._roleID;
            }
            set
            {
                if (((_roleID == value)
                            == false))
                {
                    this.OnRoleIDChanging(value);
                    this.SendPropertyChanging();
                    this._roleID = value;
                    this.SendPropertyChanged("RoleID");
                    this.OnRoleIDChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.score")]
    public partial class Score : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _id;

        private int _requirementID;

        private int _scoreID;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnRequirementIDChanged();

        partial void OnRequirementIDChanging(int value);

        partial void OnScoreIDChanged();

        partial void OnScoreIDChanging(int value);
        #endregion


        public Score()
        {
            this.OnCreated();
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_requirementID", Name = "RequirementId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int RequirementID
        {
            get
            {
                return this._requirementID;
            }
            set
            {
                if ((_requirementID != value))
                {
                    this.OnRequirementIDChanging(value);
                    this.SendPropertyChanging();
                    this._requirementID = value;
                    this.SendPropertyChanged("RequirementID");
                    this.OnRequirementIDChanged();
                }
            }
        }

        [Column(Storage = "_scoreID", Name = "ScoreId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ScoreID
        {
            get
            {
                return this._scoreID;
            }
            set
            {
                if ((_scoreID != value))
                {
                    this.OnScoreIDChanging(value);
                    this.SendPropertyChanging();
                    this._scoreID = value;
                    this.SendPropertyChanged("ScoreID");
                    this.OnScoreIDChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.scoredef")]
    public partial class ScoreDef : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _id;

        private sbyte _isEnabled;

        private string _nodeID;

        private string _title;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnIsEnabledChanged();

        partial void OnIsEnabledChanging(sbyte value);

        partial void OnNodeIDChanged();

        partial void OnNodeIDChanging(string value);

        partial void OnTitleChanged();

        partial void OnTitleChanging(string value);
        #endregion


        public ScoreDef()
        {
            this.OnCreated();
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_isEnabled", Name = "IsEnabled", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsEnabled
        {
            get
            {
                return this._isEnabled;
            }
            set
            {
                if ((_isEnabled != value))
                {
                    this.OnIsEnabledChanging(value);
                    this.SendPropertyChanging();
                    this._isEnabled = value;
                    this.SendPropertyChanged("IsEnabled");
                    this.OnIsEnabledChanged();
                }
            }
        }

        [Column(Storage = "_nodeID", Name = "NodeId", DbType = "varchar(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string NodeID
        {
            get
            {
                return this._nodeID;
            }
            set
            {
                if (((_nodeID == value)
                            == false))
                {
                    this.OnNodeIDChanging(value);
                    this.SendPropertyChanging();
                    this._nodeID = value;
                    this.SendPropertyChanged("NodeID");
                    this.OnNodeIDChanged();
                }
            }
        }

        [Column(Storage = "_title", Name = "Title", DbType = "varchar(200)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                if (((_title == value)
                            == false))
                {
                    this.OnTitleChanging(value);
                    this.SendPropertyChanging();
                    this._title = value;
                    this.SendPropertyChanged("Title");
                    this.OnTitleChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "oapr.studio")]
    public partial class Studio : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private string _desc;

        private int _id;

        private sbyte _isEnabled;

        private string _name;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnDescChanged();

        partial void OnDescChanging(string value);

        partial void OnIDChanged();

        partial void OnIDChanging(int value);

        partial void OnIsEnabledChanged();

        partial void OnIsEnabledChanging(sbyte value);

        partial void OnNameChanged();

        partial void OnNameChanging(string value);
        #endregion


        public Studio()
        {
            this.OnCreated();
        }

        [Column(Storage = "_desc", Name = "Desc", DbType = "varchar(500)", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Desc
        {
            get
            {
                return this._desc;
            }
            set
            {
                if (((_desc == value)
                            == false))
                {
                    this.OnDescChanging(value);
                    this.SendPropertyChanging();
                    this._desc = value;
                    this.SendPropertyChanged("Desc");
                    this.OnDescChanged();
                }
            }
        }

        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((_id != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [Column(Storage = "_isEnabled", Name = "IsEnabled", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public sbyte IsEnabled
        {
            get
            {
                return this._isEnabled;
            }
            set
            {
                if ((_isEnabled != value))
                {
                    this.OnIsEnabledChanging(value);
                    this.SendPropertyChanging();
                    this._isEnabled = value;
                    this.SendPropertyChanged("IsEnabled");
                    this.OnIsEnabledChanged();
                }
            }
        }

        [Column(Storage = "_name", Name = "Name", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (((_name == value)
                            == false))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    #endregion
}
