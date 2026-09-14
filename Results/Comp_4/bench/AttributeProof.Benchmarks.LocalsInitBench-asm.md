## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFEAFC6FC00]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0EFF1CCEC13A5
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,0EFF1CCEC13A5
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFEAFAA7D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFEAFC8FBE8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0FCA0C5E8CFD1
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,0FCA0C5E8CFD1
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFEAFAC7D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6F21E0D0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0F6AADAAF10FF
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0F6AADAAF10FF
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6EFAE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6F2EE0E8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0CC288F633950
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0CC288F633950
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6F07E9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6F21EBB0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,87BFFF1D5AAC
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,87BFFF1D5AAC
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6F077798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6F21EAD8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0A7CEA6C089C8
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0A7CEA6C089C8
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6F077798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFEAFC7FC00]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0ADDBC1F493C5
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,0ADDBC1F493C5
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFEAFAB7D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFEAFC6FC00]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,955DA0AAB78D
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,955DA0AAB78D
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFEAFAA7D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6F31E8E0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0F188B1425800
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0F188B1425800
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6F0AE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6F30E8F8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0E6A56CD73CB6
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0E6A56CD73CB6
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6F09E9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6F20EAD8]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,5B01FF9B3BC3
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,5B01FF9B3BC3
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6F067798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6F20EBB0]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,9FAF9043D68B
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,9FAF9043D68B
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6F067798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFEAFC6FBE8]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,9C87389F429A
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,9C87389F429A
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFEAFAA7D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFEAFC6FB28]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0EF47C6642D23
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,0EF47C6642D23
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFEAFAA7D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6EDAE8E0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0A1322D21A92
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0A1322D21A92
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6EB3E9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6EDAE8F8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,720BFCBBD785
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,720BFCBBD785
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6EB3E9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6ECBEBB0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,22171B26096E
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,22171B26096E
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6EB17798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6F20EBB0]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,498464A4A8F2
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,498464A4A8F2
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6F067798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFEAFC8FBE8]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,80D19672F91A
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,80D19672F91A
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFEAFAC7D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFEAFC6FC00]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,547927EBC05C
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,547927EBC05C
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFEAFAA7D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6F2EE8E0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0DB5CC9CA0A3B
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0DB5CC9CA0A3B
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6F07E9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6F30E8F8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,702A8E19D4F1
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,702A8E19D4F1
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6F09E9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6F22EB98]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,851FD6CFF015
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,851FD6CFF015
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6F087798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFE6F1FEAD8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0F6D26E6A9CB2
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0F6D26E6A9CB2
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFE6F057798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

