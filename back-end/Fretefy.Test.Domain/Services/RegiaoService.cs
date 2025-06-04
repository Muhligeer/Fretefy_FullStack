using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;
        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }

        public Regiao Create(Regiao regiao)
        {
            if (regiao is null)
            {
                throw new ArgumentNullException(nameof(regiao), "Região não pode ser null.");
            }

            return _regiaoRepository.Create(regiao);
        }

        public void Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID inválido.", nameof(id));
            }
            _regiaoRepository.Delete(id);
        }

        public Regiao Get(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID inválido.", nameof(id));
            }
            return _regiaoRepository.Get(id);
        }

        public IEnumerable<Regiao> List()
        {
            return _regiaoRepository.List();
        }

        public Regiao Update(Regiao regiao)
        {
            if (regiao is null)
            {
                throw new ArgumentNullException(nameof(regiao), "Região não pode ser null.");
            }
            if (regiao.Id == Guid.Empty)
            {
                throw new ArgumentException("ID inválido.", nameof(regiao.Id));
            }
            return _regiaoRepository.Update(regiao);
        }
    }
}
