using Asignacion.ProyectoFinal._6.Database.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Asignacion.ProyectoFinal._6.Database.Repositories;

public class PacienteRepository
{
    // Yes, I know. It's hardcoded for simplicity. This should be in a config file or environment variable. #BadPractice
    private static readonly string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=PacientesDB;Trusted_Connection=True;";

    private IDbConnection CreateConnection()
        => new SqlConnection(_connectionString);

    // CREATE
    public async Task<int> CreateAsync(PacienteEntity paciente)
    {
        const string sql = @"
            INSERT INTO Pacientes (codigopac, nombrepac, apelldiopac, direccionpac, telefonopac, estatuspac)
            VALUES (@CodigoPac, @NombrePac, @ApelldioPac, @DireccionPac, @TelefonoPac, @EstatusPac)";

        using var db = CreateConnection();
        return await db.ExecuteAsync(sql, paciente);
    }

    // READ (Todos)
    public async Task<IEnumerable<PacienteEntity>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Pacientes";
        using var db = CreateConnection();
        return await db.QueryAsync<PacienteEntity>(sql);
    }

    // READ (Por ID/Código)
    public async Task<PacienteEntity?> GetByCodigoAsync(string codigo)
    {
        const string sql = "SELECT * FROM Pacientes WHERE codigopac = @codigo";
        using var db = CreateConnection();
        return await db.QueryFirstOrDefaultAsync<PacienteEntity>(sql, new { codigo });
    }

    public async Task<int> UpSertAsync(PacienteEntity paciente)
    {
        // Intentamos actualizar primero
        int rowsAffected = await UpdateAsync(paciente);

        // Si no se actualizó nada (porque el código no existe), insertamos
        if (rowsAffected == 0)
        {
            rowsAffected = await CreateAsync(paciente);
        }

        return rowsAffected;
    }

    // UPDATE
    public async Task<int> UpdateAsync(PacienteEntity paciente)
    {
        const string sql = @"
            UPDATE Pacientes 
            SET nombrepac = @NombrePac, 
                apelldiopac = @ApelldioPac, 
                direccionpac = @DireccionPac, 
                telefonopac = @TelefonoPac, 
                estatuspac = @EstatusPac
            WHERE codigopac = @CodigoPac";

        using var db = CreateConnection();
        return await db.ExecuteAsync(sql, paciente);
    }

    // DELETE (Lógico o Físico)
    public async Task<int> DeleteAsync(string codigo)
    {
        const string sql = "DELETE FROM Pacientes WHERE codigopac = @codigo";
        using var db = CreateConnection();
        return await db.ExecuteAsync(sql, new { codigo });
    }
}
