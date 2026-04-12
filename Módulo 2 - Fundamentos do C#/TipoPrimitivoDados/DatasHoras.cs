using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TipoPrimitivoDados;

internal class DatasHoras
{
    static void datasHoras() {

        /* DATEONLY: Representa apenas a data (sem horário) */
        // Ideal para aniversários, datas de eventos, ou qualquer situação onde o horário não é relevante.
        DateOnly dia = new DateOnly(2026, 04, 01);

        // FORMATAÇÃO MANUAL: Usando ToString com um formato específico para exibir a data de maneira personalizada, como "dd/MM/yyyy" ou "MM-dd-yyyy"
        string dataFormatada = dia.ToString("dd/MM/yyyy");
        string dataFormatada2 = dia.ToString("MM-dd-yyyy");

        // MÉTODOS DE EXTENSÃO:
        string dataFormatada3 = dia.ToLongDateString();     // Data por extenso (ex: "quarta-feira, 1 de abril de 2026")
        string dataFormatada4 = dia.ToShortDateString();    // Data curta (ex: "01/04/2026")

        // LOCALIZAÇÃO (CULTURAS): Formata seguindo as regras de um país específico, como "pt-BR" para português do Brasil, onde a data é exibida no formato tradicional brasileiro 
        string dataFormatada5 = dia.ToString(new CultureInfo("pt-BR"));
        string dataFormatada6 = dia.ToString("D", new CultureInfo("pt-BR")); // "D" é um atalho para o formato de data longa daquela cultura


        /* DATETIME: Armazena data e hora completa */
        // Representa data e hora, ideal para situações onde ambos são relevantes, como agendamento de compromissos, registros de eventos, ou qualquer cenário onde o horário é importante.
        DateTime dataHora = new DateTime(2026, 04, 01, 14, 30, 00);

        // CAPTURA DO SISTEMA:
        DateTime hojeDiaHora = DateTime.Now;    // Data e hora atual do computador
        DateTime hojeDia = DateTime.Today;      // Data atual sem a parte de hora (hora é definida como 00:00:00)
        DateTime hojeDiaHoraUtc = DateTime.UtcNow;  // Data e hora universal coordenada (UTC), que é a referência global para fusos horários, útil para aplicações que precisam ser consistentes em diferentes regiões do mundo

        // CONVERSÕES E ARITMÉTICA:
        DateTime hojeDiaHoraLocal = DateTime.Now.ToLocalTime(); // Converte a data e hora atual para o horário local do sistema, garantindo que a data e hora sejam exibidas de acordo com o fuso horário configurado no computador
        DateTime ontem = hojeDiaHoraLocal.AddDays(-1);  // Subtrai um dia da data atual, útil para calcular datas passadas ou futuras de maneira simples e eficiente
    }

}
