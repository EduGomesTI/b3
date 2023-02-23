﻿using System.Text.Json.Serialization;

namespace B3.DesafioTecnico.Application.Base.Entities
{
    public abstract class BaseResponse
    {

        #region Properties

        public bool Success { get; private set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<string> Messages { get; set; }

        #endregion

        #region Constructors

        public BaseResponse() => Messages = new List<string>();

        public BaseResponse(bool success) : this() => Success = success;

        #endregion

        #region Methods

        public void AddMessages(IEnumerable<string> messages) => Messages.AddRange(messages);

        #endregion
    }
}
