namespace TipoPrimitivoDados;

class TiposNumericos
{
    static void tiposNumericos()
    {
        /* NÚMEROS INTEIROS (SEM CASAS DECIMAIS) */

        // 8 bits: Menor pegada na memória, mas menor alcance de valores.
        sbyte numeroSByte = -128;   // Com sinal (-128 a 127)
        byte numeroByte2 = 0;       // Sem sinal (0 a 255)

        // 16 bits: Um pouco mais de alcance, mas ainda eficiente para muitos casos.
        short numeroShortNegativo = -32768;     // Com sinal (-32.768 a 32.767)
        ushort numeroShort = 65535;             // Sem sinal (0 a 65.535)

        // 32 bits: Comum para muitos cálculos, mas pode ser insuficiente para grandes valores.
        int numeroInt = -1;      // Com sinal (-2.147.483.648 a 2.147.483.647)
        uint numeroInt2 = 0;    // Sem sinal (0 a 4.294.967.295)

        // 64 bits: Grande alcance, mas maior pegada na memória. Ideal para grandes números.
        long numeroLongo = 10000000;        // Com sinal (-9.223.372.036.854.775.808 a 9.223.372.036.854.775.807)
        ulong numeroLongo2 = 184460000;     // Sem sinal (0 a 18.446.744.073.709.551.615)

        // 128 bits: Muito grande, usado para números extremamente grandes ou pequenos.
        nint numeroNInt = -9;         // Com sinal (-9.223.372.036.854.775.808 a 9.223.372.036.854.775.807)
        nuint numeroNUInt = 0;       // Sem sinal (0 a 18.446.744.073.709.551.615)



        /* PONTO FLUTUANTE (DECIMAIS) */

        // Precisão simples (7 dígitos): Mais rápido, usa menos memória. Requer sufixo 'F' ou 'f'.
        float numeroFloat = 3.14F;

        // Precisão dupla (15-16 dígitos): O padrão do C# para cálculos científicos e gerais.
        double numeroDouble = 3.14;

        // Precisão financeira (28-29 dígitos): Ideal para cálculos financeiros, onde a precisão é crucial. Requer sufixo 'M' ou 'm'.
        decimal numeroDecimal = 3.14M;



        /* LEGIBILIDADE */

        // C# permite usar underline para melhorar a legibilidade de números grandes, sem afetar o valor.
        int numeroComUnderline = 1_000_000; 
        float numeroFloatComUnderline = 3.14_15F;

    }
}
