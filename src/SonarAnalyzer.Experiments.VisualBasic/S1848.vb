Namespace S1848

    Enum Compliant
        SomeValue
        Reserve
    End Enum

    Enum NonCompliant
        ReservedValue 'Noncompliant {Remove or rename this enum member.}
        '       ^^^^^^^^^^^^^
        PrefixedReserved 'Noncompliant
        Reserved 'Noncompliant
        RESERVED_UPPER_CASE 'Noncompliant
    End Enum

End Namespace