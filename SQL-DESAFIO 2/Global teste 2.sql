SELECT
        PESSOA.NR_PROCESSO         ,
        CONTA_A_PAGAR.NM_FORNECEDOR,
        CONTA_PAGA.DT_VENCIMENTO   ,
        CONTA_PAGA.DT_PAGAMENTO    ,
        CONTA_PAGA.VLR_LIQUIDO     ,
        CASE WHEN CONTA_PAGA.DT_PAGAMENTO <> NULL THEN 'PAGO' ELSE 'A-PAGAR' END AS CONTA_PAGA.DT_PAGAMENTO
FROM
        CONTA_A_PAGAR
INNER JOIN
        CONTA_PAGA
ON
        CONTA_A_PAGAR.CD_FORNECEDOR = CONTA_PAGA.CD_FORNECEDOR
INNER JOIN
        PESSOA
ON
        CONTA_A_PAGAR.CPF_CNPJ = PESSOA.CPF_CNPJ
WHERE
        NM_PESSOA = '???????'
AND     CPF_CNPJ  = ???????