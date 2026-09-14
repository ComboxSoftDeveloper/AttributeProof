## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.Library()
       mov       ecx,2C58BC0
       jmp       qword ptr [7FFEAFC5FAF8]; AttributeProof.Subjects.CheckByLibrary(System.String)
; Total bytes of code 11
```
```assembly
; AttributeProof.Subjects.CheckByLibrary(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,28
       ret
M01_L00:
       mov       ecx,67
       mov       rdx,7FFEAFB2BE48
       call      qword ptr [7FFEAF88F210]
       mov       rcx,rax
       call      qword ptr [7FFEAFD15A28]
       int       3
; Total bytes of code 48
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.ByHand()
       mov       ecx,2D28BC0
       jmp       qword ptr [7FFEAFC9FBD0]; AttributeProof.Subjects.CheckByHand(System.String)
; Total bytes of code 11
```
```assembly
; AttributeProof.Subjects.CheckByHand(System.String)
       push      rbx
       sub       rsp,20
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,67
       mov       rdx,7FFEAFB6BE48
       call      qword ptr [7FFEAF8CF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEAFBF75A0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 79
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.Library()
       mov       ecx,2FC8DA8
       jmp       qword ptr [7FFE6EDCE958]; AttributeProof.Subjects.CheckByLibrary(System.String)
; Total bytes of code 11
```
```assembly
; AttributeProof.Subjects.CheckByLibrary(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,28
       ret
M01_L00:
       mov       ecx,67
       mov       rdx,7FFE6EBA1528
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE6EB866E8]
       int       3
; Total bytes of code 47
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.ByHand()
       mov       ecx,2EC8DA8
       jmp       qword ptr [7FFE6ED9E970]; AttributeProof.Subjects.CheckByHand(System.String)
; Total bytes of code 11
```
```assembly
; AttributeProof.Subjects.CheckByHand(System.String)
       push      rbx
       sub       rsp,20
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,67
       mov       rdx,7FFE6EB71528
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE6EB56640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.Library()
       mov       ecx,2E99058
       jmp       qword ptr [7FFE6ECCEB68]; AttributeProof.Subjects.CheckByLibrary(System.String)
; Total bytes of code 11
```
```assembly
; AttributeProof.Subjects.CheckByLibrary(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,28
       ret
M01_L00:
       mov       ecx,67
       mov       rdx,7FFE6EBA5CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE6ED94BA0]
       int       3
; Total bytes of code 47
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.ByHand()
       mov       ecx,2E69058
       jmp       qword ptr [7FFE6F21EAA8]; AttributeProof.Subjects.CheckByHand(System.String)
; Total bytes of code 11
```
```assembly
; AttributeProof.Subjects.CheckByHand(System.String)
       push      rbx
       sub       rsp,20
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,67
       mov       rdx,7FFE6F0F5CD8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE6F1866E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

