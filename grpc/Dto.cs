// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: catalog/dto.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace prodrink.catalog {

  /// <summary>Holder for reflection information generated from catalog/dto.proto</summary>
  public static partial class DtoReflection {

    #region Descriptor
    /// <summary>File descriptor for catalog/dto.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DtoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFjYXRhbG9nL2R0by5wcm90bxIHY2F0YWxvZxoTY2F0YWxvZy9kcmluay5w",
            "cm90byIxCgxEcmlua1JlcXVlc3QSEAoIZHJpbmtfaWQYASABKAUSDwoHdXNl",
            "cl9pZBgCIAEoCSJKChBEcmlua1BhZ2VSZXF1ZXN0Eg8KB3VzZXJfaWQYASAB",
            "KAkSEwoLcGFnZV9udW1iZXIYAiABKAUSEAoIcGVyX3BhZ2UYAyABKAUiGwoZ",
            "VG9wTGV2ZWxDYXRlZ29yaWVzUmVxdWVzdCJBChlEcmlua3NGcm9tQ2F0ZWdv",
            "cnlSZXF1ZXN0EhMKC2NhdGVnb3J5X2lkGAEgASgFEg8KB3VzZXJfaWQYAiAB",
            "KAkiMQoVRHJpbmtDcmVhdGlvblJlc3BvbnNlEhgKEGNyZWF0ZWRfZHJpbmtf",
            "aWQYASABKAUiRQoSRHJpbmtVcGRhdGVSZXF1ZXN0EhAKCGRyaW5rX2lkGAEg",
            "ASgFEh0KBWRyaW5rGAIgASgLMg4uY2F0YWxvZy5EcmluayIVChNEcmlua1Vw",
            "ZGF0ZVJlc3BvbnNlIigKFERyaW5rRGVsZXRpb25SZXF1ZXN0EhAKCGRyaW5r",
            "X2lkGAEgASgFIhcKFURyaW5rRGVsZXRpb25SZXNwb25zZUI9Chdpby5wcm9k",
            "cmluay5jYXRhbG9nLmR0b0INRHJpbmtEdG9PdXRlclABqgIQcHJvZHJpbmsu",
            "Y2F0YWxvZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::prodrink.catalog.DrinkReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::prodrink.catalog.DrinkRequest), global::prodrink.catalog.DrinkRequest.Parser, new[]{ "DrinkId", "UserId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::prodrink.catalog.DrinkPageRequest), global::prodrink.catalog.DrinkPageRequest.Parser, new[]{ "UserId", "PageNumber", "PerPage" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::prodrink.catalog.TopLevelCategoriesRequest), global::prodrink.catalog.TopLevelCategoriesRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::prodrink.catalog.DrinksFromCategoryRequest), global::prodrink.catalog.DrinksFromCategoryRequest.Parser, new[]{ "CategoryId", "UserId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::prodrink.catalog.DrinkCreationResponse), global::prodrink.catalog.DrinkCreationResponse.Parser, new[]{ "CreatedDrinkId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::prodrink.catalog.DrinkUpdateRequest), global::prodrink.catalog.DrinkUpdateRequest.Parser, new[]{ "DrinkId", "Drink" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::prodrink.catalog.DrinkUpdateResponse), global::prodrink.catalog.DrinkUpdateResponse.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::prodrink.catalog.DrinkDeletionRequest), global::prodrink.catalog.DrinkDeletionRequest.Parser, new[]{ "DrinkId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::prodrink.catalog.DrinkDeletionResponse), global::prodrink.catalog.DrinkDeletionResponse.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DrinkRequest : pb::IMessage<DrinkRequest> {
    private static readonly pb::MessageParser<DrinkRequest> _parser = new pb::MessageParser<DrinkRequest>(() => new DrinkRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DrinkRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::prodrink.catalog.DtoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkRequest(DrinkRequest other) : this() {
      drinkId_ = other.drinkId_;
      userId_ = other.userId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkRequest Clone() {
      return new DrinkRequest(this);
    }

    /// <summary>Field number for the "drink_id" field.</summary>
    public const int DrinkIdFieldNumber = 1;
    private int drinkId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DrinkId {
      get { return drinkId_; }
      set {
        drinkId_ = value;
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 2;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DrinkRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DrinkRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DrinkId != other.DrinkId) return false;
      if (UserId != other.UserId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DrinkId != 0) hash ^= DrinkId.GetHashCode();
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (DrinkId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(DrinkId);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UserId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DrinkId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DrinkId);
      }
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DrinkRequest other) {
      if (other == null) {
        return;
      }
      if (other.DrinkId != 0) {
        DrinkId = other.DrinkId;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            DrinkId = input.ReadInt32();
            break;
          }
          case 18: {
            UserId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DrinkPageRequest : pb::IMessage<DrinkPageRequest> {
    private static readonly pb::MessageParser<DrinkPageRequest> _parser = new pb::MessageParser<DrinkPageRequest>(() => new DrinkPageRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DrinkPageRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::prodrink.catalog.DtoReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkPageRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkPageRequest(DrinkPageRequest other) : this() {
      userId_ = other.userId_;
      pageNumber_ = other.pageNumber_;
      perPage_ = other.perPage_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkPageRequest Clone() {
      return new DrinkPageRequest(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_number" field.</summary>
    public const int PageNumberFieldNumber = 2;
    private int pageNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PageNumber {
      get { return pageNumber_; }
      set {
        pageNumber_ = value;
      }
    }

    /// <summary>Field number for the "per_page" field.</summary>
    public const int PerPageFieldNumber = 3;
    private int perPage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PerPage {
      get { return perPage_; }
      set {
        perPage_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DrinkPageRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DrinkPageRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (PageNumber != other.PageNumber) return false;
      if (PerPage != other.PerPage) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (PageNumber != 0) hash ^= PageNumber.GetHashCode();
      if (PerPage != 0) hash ^= PerPage.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserId);
      }
      if (PageNumber != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PageNumber);
      }
      if (PerPage != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(PerPage);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (PageNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageNumber);
      }
      if (PerPage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PerPage);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DrinkPageRequest other) {
      if (other == null) {
        return;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      if (other.PageNumber != 0) {
        PageNumber = other.PageNumber;
      }
      if (other.PerPage != 0) {
        PerPage = other.PerPage;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            UserId = input.ReadString();
            break;
          }
          case 16: {
            PageNumber = input.ReadInt32();
            break;
          }
          case 24: {
            PerPage = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TopLevelCategoriesRequest : pb::IMessage<TopLevelCategoriesRequest> {
    private static readonly pb::MessageParser<TopLevelCategoriesRequest> _parser = new pb::MessageParser<TopLevelCategoriesRequest>(() => new TopLevelCategoriesRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TopLevelCategoriesRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::prodrink.catalog.DtoReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TopLevelCategoriesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TopLevelCategoriesRequest(TopLevelCategoriesRequest other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TopLevelCategoriesRequest Clone() {
      return new TopLevelCategoriesRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TopLevelCategoriesRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TopLevelCategoriesRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TopLevelCategoriesRequest other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class DrinksFromCategoryRequest : pb::IMessage<DrinksFromCategoryRequest> {
    private static readonly pb::MessageParser<DrinksFromCategoryRequest> _parser = new pb::MessageParser<DrinksFromCategoryRequest>(() => new DrinksFromCategoryRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DrinksFromCategoryRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::prodrink.catalog.DtoReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinksFromCategoryRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinksFromCategoryRequest(DrinksFromCategoryRequest other) : this() {
      categoryId_ = other.categoryId_;
      userId_ = other.userId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinksFromCategoryRequest Clone() {
      return new DrinksFromCategoryRequest(this);
    }

    /// <summary>Field number for the "category_id" field.</summary>
    public const int CategoryIdFieldNumber = 1;
    private int categoryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CategoryId {
      get { return categoryId_; }
      set {
        categoryId_ = value;
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 2;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DrinksFromCategoryRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DrinksFromCategoryRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CategoryId != other.CategoryId) return false;
      if (UserId != other.UserId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CategoryId != 0) hash ^= CategoryId.GetHashCode();
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CategoryId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CategoryId);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UserId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CategoryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CategoryId);
      }
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DrinksFromCategoryRequest other) {
      if (other == null) {
        return;
      }
      if (other.CategoryId != 0) {
        CategoryId = other.CategoryId;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            CategoryId = input.ReadInt32();
            break;
          }
          case 18: {
            UserId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DrinkCreationResponse : pb::IMessage<DrinkCreationResponse> {
    private static readonly pb::MessageParser<DrinkCreationResponse> _parser = new pb::MessageParser<DrinkCreationResponse>(() => new DrinkCreationResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DrinkCreationResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::prodrink.catalog.DtoReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkCreationResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkCreationResponse(DrinkCreationResponse other) : this() {
      createdDrinkId_ = other.createdDrinkId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkCreationResponse Clone() {
      return new DrinkCreationResponse(this);
    }

    /// <summary>Field number for the "created_drink_id" field.</summary>
    public const int CreatedDrinkIdFieldNumber = 1;
    private int createdDrinkId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CreatedDrinkId {
      get { return createdDrinkId_; }
      set {
        createdDrinkId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DrinkCreationResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DrinkCreationResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CreatedDrinkId != other.CreatedDrinkId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CreatedDrinkId != 0) hash ^= CreatedDrinkId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CreatedDrinkId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CreatedDrinkId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CreatedDrinkId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CreatedDrinkId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DrinkCreationResponse other) {
      if (other == null) {
        return;
      }
      if (other.CreatedDrinkId != 0) {
        CreatedDrinkId = other.CreatedDrinkId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            CreatedDrinkId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DrinkUpdateRequest : pb::IMessage<DrinkUpdateRequest> {
    private static readonly pb::MessageParser<DrinkUpdateRequest> _parser = new pb::MessageParser<DrinkUpdateRequest>(() => new DrinkUpdateRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DrinkUpdateRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::prodrink.catalog.DtoReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkUpdateRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkUpdateRequest(DrinkUpdateRequest other) : this() {
      drinkId_ = other.drinkId_;
      Drink = other.drink_ != null ? other.Drink.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkUpdateRequest Clone() {
      return new DrinkUpdateRequest(this);
    }

    /// <summary>Field number for the "drink_id" field.</summary>
    public const int DrinkIdFieldNumber = 1;
    private int drinkId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DrinkId {
      get { return drinkId_; }
      set {
        drinkId_ = value;
      }
    }

    /// <summary>Field number for the "drink" field.</summary>
    public const int DrinkFieldNumber = 2;
    private global::prodrink.catalog.Drink drink_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::prodrink.catalog.Drink Drink {
      get { return drink_; }
      set {
        drink_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DrinkUpdateRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DrinkUpdateRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DrinkId != other.DrinkId) return false;
      if (!object.Equals(Drink, other.Drink)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DrinkId != 0) hash ^= DrinkId.GetHashCode();
      if (drink_ != null) hash ^= Drink.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (DrinkId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(DrinkId);
      }
      if (drink_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Drink);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DrinkId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DrinkId);
      }
      if (drink_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Drink);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DrinkUpdateRequest other) {
      if (other == null) {
        return;
      }
      if (other.DrinkId != 0) {
        DrinkId = other.DrinkId;
      }
      if (other.drink_ != null) {
        if (drink_ == null) {
          drink_ = new global::prodrink.catalog.Drink();
        }
        Drink.MergeFrom(other.Drink);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            DrinkId = input.ReadInt32();
            break;
          }
          case 18: {
            if (drink_ == null) {
              drink_ = new global::prodrink.catalog.Drink();
            }
            input.ReadMessage(drink_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class DrinkUpdateResponse : pb::IMessage<DrinkUpdateResponse> {
    private static readonly pb::MessageParser<DrinkUpdateResponse> _parser = new pb::MessageParser<DrinkUpdateResponse>(() => new DrinkUpdateResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DrinkUpdateResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::prodrink.catalog.DtoReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkUpdateResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkUpdateResponse(DrinkUpdateResponse other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkUpdateResponse Clone() {
      return new DrinkUpdateResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DrinkUpdateResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DrinkUpdateResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DrinkUpdateResponse other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class DrinkDeletionRequest : pb::IMessage<DrinkDeletionRequest> {
    private static readonly pb::MessageParser<DrinkDeletionRequest> _parser = new pb::MessageParser<DrinkDeletionRequest>(() => new DrinkDeletionRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DrinkDeletionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::prodrink.catalog.DtoReflection.Descriptor.MessageTypes[7]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkDeletionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkDeletionRequest(DrinkDeletionRequest other) : this() {
      drinkId_ = other.drinkId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkDeletionRequest Clone() {
      return new DrinkDeletionRequest(this);
    }

    /// <summary>Field number for the "drink_id" field.</summary>
    public const int DrinkIdFieldNumber = 1;
    private int drinkId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DrinkId {
      get { return drinkId_; }
      set {
        drinkId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DrinkDeletionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DrinkDeletionRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DrinkId != other.DrinkId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DrinkId != 0) hash ^= DrinkId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (DrinkId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(DrinkId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DrinkId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DrinkId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DrinkDeletionRequest other) {
      if (other == null) {
        return;
      }
      if (other.DrinkId != 0) {
        DrinkId = other.DrinkId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            DrinkId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DrinkDeletionResponse : pb::IMessage<DrinkDeletionResponse> {
    private static readonly pb::MessageParser<DrinkDeletionResponse> _parser = new pb::MessageParser<DrinkDeletionResponse>(() => new DrinkDeletionResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DrinkDeletionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::prodrink.catalog.DtoReflection.Descriptor.MessageTypes[8]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkDeletionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkDeletionResponse(DrinkDeletionResponse other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DrinkDeletionResponse Clone() {
      return new DrinkDeletionResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DrinkDeletionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DrinkDeletionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DrinkDeletionResponse other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
